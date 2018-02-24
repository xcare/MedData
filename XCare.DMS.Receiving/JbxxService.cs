using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Configuration.Jbxx;
using XCare.DMS.Message.Jbxx;

namespace XCare.DMS.Receiving
{
    public class JbxxService
    {
        public void Create(YdhlJbxx jbxx)
        {
            JbxxMessageForwarder.Forward(new JbxxCreatedMessage(jbxx));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}