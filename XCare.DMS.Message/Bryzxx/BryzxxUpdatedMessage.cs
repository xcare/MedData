using System.Collections.Generic;
using XCare.DMS.Entity;

namespace XCare.DMS.Message.Bryzxx
{
    public class BryzxxUpdatedMessage
    {
        public List<YdhlBryzxx> Bryzxxes { get; set; }
    }
}