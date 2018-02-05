using System;
using XCare.DMS.Utilities.Event;

namespace XCare.DMS.Uploading.Events.Bryz
{
    public class BryzxxUpdatedEventHandler : IEventHandler<BryzxxUpdatedEvent>
    {
        public void Handle(BryzxxUpdatedEvent @event)
        {
            Console.WriteLine("BryzxxUpdatedEvent");
        }
    }
}
