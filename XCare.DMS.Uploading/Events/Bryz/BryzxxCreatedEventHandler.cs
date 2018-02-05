using System;
using XCare.DMS.Uploading.Events.Bryz;
using XCare.DMS.Utilities.Event;

namespace XCare.DMS.Uploading.Events.Bryz
{
    public class BryzxxCreatedEventHandler:IEventHandler<BryzxxCreatedEvent>
    {
        public void Handle(BryzxxCreatedEvent @event)
        {
            Console.WriteLine("BryzxxCreatedEvent");
        }
    }
}