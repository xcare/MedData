using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Configuration.Jybg;
using XCare.DMS.Message.Jybg;
using XCare.DMS.Message.Twd;

namespace XCare.DMS.Message.Configuration.Twd
{
    public class TwdMessageForwarder
    {
        private static readonly IBusControl CreateBus = new TwdCreatedMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new TwdUpdatedMessageBusConfig().CreateBus();

        public static void Forward(TwdCreatedMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Forward(TwdUpdatedMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}
