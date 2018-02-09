using System;

namespace XCare.DMS.DataProc.Daemon
{
    internal class DataChangedEventNotification
    {
        public string ApplicationName { get; set; }
        public string TableName { get; set; }
        public DataManipulationOption Action { get; set; }
        public object ObjectId { get; set; }
        public DateTime ActionTime { get; set; }
    }
}