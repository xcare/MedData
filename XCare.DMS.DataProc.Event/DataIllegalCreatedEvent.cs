using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCare.DMS.DataProc.Event
{
    public class DataIllegalCreatedEvent
    {
        public string TableName { get; set; }
        public string TableDescription { get; set; }
    }
}
