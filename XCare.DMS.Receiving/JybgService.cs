using System;
using System.Collections.Generic;
using XCare.DMS.Entity;
using XCare.DMS.Message.Configuration.Jybg;
using XCare.DMS.Message.Jybg;

namespace XCare.DMS.Receiving
{
    public class JybgService
    {
        public void Create(IEnumerable<YdhlJybg> jybgs)
        {
            JybgMessageForwarder.Forward(new JybgCreatedMessage(jybgs));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}