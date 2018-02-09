using System;

namespace XCare.DMS.DataProc.Event
{
    public class DataDeletedEvent<T> where T : new()
    {
        public DateTime DeletedTime { get; set; }
        public string TableName { get; set; }
        public T Id { get; set; }
    }
}