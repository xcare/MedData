using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCare.DMS.Utilities.Event;

namespace XCare.DMS.Uploading.Events.Jbxx
{
    public class JbxxUpdatedEventHandler : IEventHandler<JbxxUpdatedEvent>
    {
        public void Handle(JbxxUpdatedEvent @event)
        {
            Console.WriteLine("JbxxUpdatedEvent");
        }
    }
}
