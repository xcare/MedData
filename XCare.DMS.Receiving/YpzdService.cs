using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Configuration.Ypzd;
using XCare.DMS.Message.Ypzd;

namespace XCare.DMS.Receiving
{
    public class YpzdService
    {
        public void Create(YdhlYpzd zd)
        {
            YpzdMessageForwarder.Forward(new YpzdCreatedMessage(zd));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}