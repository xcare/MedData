using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Configuration.Jbbm;
using XCare.DMS.Message.Jbbm;

namespace XCare.DMS.Receiving
{
    public class JbbmService
    {
        public void Create(YdhlJbbm jbbm)
        {
            JbbmMessageForwarder.Forward(new JbbmCreatedMessage(jbbm));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}