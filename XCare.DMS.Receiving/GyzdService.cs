using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Configuration.Gyzd;
using XCare.DMS.Message.Gyzd;

namespace XCare.DMS.Receiving
{
    public class GyzdService
    {
        public void Create(YdhlGyzd zd)
        {
            GyzdMessageForwarder.Forward(new GyzdCreatedMessage(zd));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}