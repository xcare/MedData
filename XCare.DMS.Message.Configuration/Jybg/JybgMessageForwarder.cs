using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Configuration.Jcbg;
using XCare.DMS.Message.Jcbg;
using XCare.DMS.Message.Jybg;

namespace XCare.DMS.Message.Configuration.Jybg
{
    public class JybgMessageForwarder
    {
        private static readonly IBusControl CreateBus = new JybgCreatedMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new JybgUpdatedMessageBusConfig().CreateBus();

        public static void Forward(JybgCreatedMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Forward(JybgUpdatedMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}
