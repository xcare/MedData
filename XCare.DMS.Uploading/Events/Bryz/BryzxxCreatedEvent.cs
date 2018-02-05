using System.Collections.Generic;
using XCare.DMS.Entity;

namespace XCare.DMS.Uploading.Events.Bryz
{
    public class BryzxxCreatedEvent
    {
        public BryzxxCreatedEvent(List<YdhlBryzxx> bryzxxes)
        {
            Bryzxxes = bryzxxes;
        }

        public List<YdhlBryzxx> Bryzxxes { get; private set; }
    }
}