using System;

namespace XCare.DMS.DataProc.Event
{
    public class DataUpdatedEvent<T> where T : new()
    {
        public T Id { get; set; }
    }
}