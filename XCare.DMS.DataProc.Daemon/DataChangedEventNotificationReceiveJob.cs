using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using log4net;
using Quartz;
using ServiceBroker.Net;
using XCare.DMS.DataProc.Daemon.Extension;

namespace XCare.DMS.DataProc.Daemon
{
    [DisallowConcurrentExecution]
    internal class DataChangedEventNotificationReceiveJob : IJob
    {
        private static readonly Type DataManipulationOptionType = typeof (DataManipulationOption);

        private static readonly string XCareConnectionString =
            ConfigurationManager.ConnectionStrings["XCareConnectionString"].ConnectionString;

        private static readonly ILog DmlMsgLog = LogManager.GetLogger("DMLMsgLogger");
        private static readonly ILog ErrorLog = LogManager.GetLogger("ErrorLogger");
        
        public void Execute(IJobExecutionContext context)
        {
            using (var conn = new SqlConnection(XCareConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    var messages = TryReceiveMessage(trans);
                    if (messages.Any())
                    {
                        foreach (var message in messages)
                        {
                            try
                            {
                                DataChangedEventNotificationDistributor.Distribute(ResolveNotification(message));
                                DmlMsgLog.Info(Encoding.Unicode.GetString(message.Body));
                            }
                            catch (Exception e)
                            {
                                ErrorLog.Error("分发DML消息失败", e);
                            }
                        }
                    }
                    trans.Commit();
                }
            }
        }

        private static List<Message> TryReceiveMessage(SqlTransaction trans)
        {
            List<Message> messages = null;
            try
            {
                messages = ServiceBrokerWrapper.WaitAndReceive(trans, "DataChangedEventNotificationQueue", 1000, 2000)
                    .ToList();
            }
            catch (Exception e)
            {
                ErrorLog.Error("接收DML事件通知失败", e);
            }
            return messages;
        }

        public static DataChangedEventNotification ResolveNotification(Message message)
        {
            var notification = new DataChangedEventNotification();
            var umsg = XDocument.Load(message.BodyStream).Descendants("umsg").First();
            if (umsg != null)
            {
                notification.ApplicationName = umsg.Element("host").TryGetValue();
                notification.Action = (DataManipulationOption)
                    Enum.Parse(DataManipulationOptionType, umsg.Element("action").TryGetValue());
                notification.ActionTime = DateTime.Parse(umsg.Element("actionTime").TryGetValue());
                notification.ObjectId = umsg.Element("objectId").TryGetValue();
                notification.TableName = umsg.Element("table").TryGetValue();
            }
            return notification;
        }
    }
}