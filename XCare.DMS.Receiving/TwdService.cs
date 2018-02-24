using System;
using System.Collections.Generic;
using XCare.DMS.Entity;
using XCare.DMS.Message.Configuration.Twd;
using XCare.DMS.Message.Twd;

namespace XCare.DMS.Receiving
{
    public class TwdService
    {
        public void Create(IEnumerable<YdhlTwd> twds)
        {
            TwdMessageForwarder.Forward(new TwdCreatedMessage(twds));
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}