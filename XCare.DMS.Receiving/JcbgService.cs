using System;
using System.Collections.Generic;
using XCare.DMS.Entity;
using XCare.DMS.Message.Configuration.Jcbg;
using XCare.DMS.Message.Jcbg;

namespace XCare.DMS.Receiving
{
    public class JcbgService
    {
        public void Create(IEnumerable<YdhlJcbg> jcbgs)
        {
            JcbgMessageForwarder.Forward(new JcbgCreatedMessage(jcbgs));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}