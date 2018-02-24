using System.Collections.Generic;
using XCare.DMS.Entity;

namespace XCare.DMS.Message.Jybg
{
    public class JybgCreatedMessage
    {
        public JybgCreatedMessage(){}

        public JybgCreatedMessage(IEnumerable<YdhlJybg> jybgs)
        {
            Jybgs = jybgs;
        }
        public IEnumerable<YdhlJybg> Jybgs { get; set; }
    }
}