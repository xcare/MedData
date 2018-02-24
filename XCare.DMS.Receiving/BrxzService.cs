using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Brxz;
using XCare.DMS.Message.Configuration.Brxz;

namespace XCare.DMS.Receiving
{
    public class BrxzService
    {
        public void Create(YdhlBrxz brxz)
        {
            BrxzMessageForwarder.Forward(new BrxzCreatedMessage(brxz));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}