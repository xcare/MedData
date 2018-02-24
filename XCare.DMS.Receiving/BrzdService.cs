using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Brzd;
using XCare.DMS.Message.Configuration.Brzd;

namespace XCare.DMS.Receiving
{
    public class BrzdService
    {
        public void Create(YdhlBrzd brzd)
        {
            BrzdMessageForwarder.Forward(new BrzdCreatedMessage(brzd));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}