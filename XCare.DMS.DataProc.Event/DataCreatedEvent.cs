using System;

namespace XCare.DMS.DataProc.Event
{
    public class DataCreatedEvent<T> where T : new()
    {
        public T Id { get; set; }
    }
}