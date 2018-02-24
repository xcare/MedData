using System;
using XCare.DMS.Entity;
using XCare.DMS.Message.Configuration.Ypyf;
using XCare.DMS.Message.Ypyf;

namespace XCare.DMS.Receiving
{
    public class YpyfService
    {
        public void Create(YdhlYpyf ypyf)
        {
            YpyfMessageForwarder.Forward(new YpyfCreatedMessage(ypyf));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}