using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;
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

        public void Execute(IJobExecutionContext context)
        {
            using (var conn = new SqlConnection(XCareConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        var messages =
                            ServiceBrokerWrapper.WaitAndReceive(trans, "DataChangedEventNotificationQueue", 1000, 2000)
                                .ToList();
                        if (messages.Any())
                        {
                            foreach (var message in messages)
                            {
                                DataChangedEventNotificationDistributor.Distribute(ResolveNotification(message));
                            }
                        }
                        trans.Commit();
                    }
                    catch (Exception)
                    {
                        trans.Commit();
                    }
                }
            }
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
                notification.ObjectId = umsg.Element("actionTime").TryGetValue();
                notification.TableName = umsg.Element("table").TryGetValue();
            }
            return notification;
        }
    }
}