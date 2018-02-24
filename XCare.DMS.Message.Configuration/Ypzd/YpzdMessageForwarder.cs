using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Configuration.Ypyf;
using XCare.DMS.Message.Ypyf;
using XCare.DMS.Message.Ypzd;

namespace XCare.DMS.Message.Configuration.Ypzd
{
    public class YpzdMessageForwarder
    {
        private static readonly IBusControl CreateBus = new YpzdCreatedMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new YpzdUpdatedMessageBusConfig().CreateBus();

        public static void Forward(YpzdCreatedMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Forward(YpzdUpdatedMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}
