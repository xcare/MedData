using System;
using System.Text;
using System.Xml.Serialization;

namespace XCare.DMS.DataProc.Daemon
{
    [XmlRoot("umsg")]
    public class DataChangedEventNotification
    {
        [XmlElement("host")]
        public string ApplicationName { get; set; }

        [XmlElement("table")]
        public string TableName { get; set; }

        [XmlElement("action")]
        public DataManipulationOption Action { get; set; }

        [XmlElement("objectId")]
        public string ObjectId { get; set; }

        [XmlIgnore]
        public DateTime ActionTime { get; set; }

        [XmlElement("actionTime")]
        public string ActionTimeString
        {
            get { return ActionTime.ToString("yyyy-MM-dd hh:mm:ss:fff"); }
            set { ActionTime = DateTime.Parse(value); }
        }

        public string ToLog()
        {
            var sb = new StringBuilder();
            sb.AppendFormat(" 客户端:{0}<BR/>", ApplicationName);
            sb.AppendFormat(" 表:{0}<BR/>", TableName);
            sb.AppendFormat(" 操作:{0}<BR/>", Action);
            sb.AppendFormat(" 对象ID:{0}<BR/>", ObjectId);
            sb.AppendFormat(" 操作时间:{0}<BR/>", ActionTimeString);
            return sb.ToString();
        }
    }
}