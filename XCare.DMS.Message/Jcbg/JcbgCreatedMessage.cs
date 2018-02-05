using System.Collections.Generic;
using XCare.DMS.Entity;

namespace XCare.DMS.Message.Jcbg
{
    public class JcbgCreatedMessage
    {
        public List<YdhlJcbg> Jcbgs { get; set; }
    }
}