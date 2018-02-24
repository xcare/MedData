using System.Collections.Generic;
using XCare.DMS.Entity;

namespace XCare.DMS.Message.Jcbg
{
    public class JcbgCreatedMessage
    {
        public JcbgCreatedMessage()
        {
        }

        public JcbgCreatedMessage(IEnumerable<YdhlJcbg> jcbgs)
        {
            Jcbgs = jcbgs;
        }

        public IEnumerable<YdhlJcbg> Jcbgs { get; set; }
    }
}