using System.Collections.Generic;
using XCare.DMS.Entity;

namespace XCare.DMS.Message.Bryzxx
{
    public class BryzxxCreatedMessage
    {
        public BryzxxCreatedMessage()
        {
        }

        public BryzxxCreatedMessage(IEnumerable<YdhlBryzxx> bryzxxes)
        {
            Bryzxxes = bryzxxes;
        }

        public IEnumerable<YdhlBryzxx> Bryzxxes { get; set; }
    }
}