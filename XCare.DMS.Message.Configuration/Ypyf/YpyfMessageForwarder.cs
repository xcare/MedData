using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Configuration.Twd;
using XCare.DMS.Message.Twd;
using XCare.DMS.Message.Ypyf;

namespace XCare.DMS.Message.Configuration.Ypyf
{
    public class YpyfMessageForwarder
    {
        private static readonly IBusControl CreateBus = new YpyfCreatedMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new YpyfUpdatedMessageBusConfig().CreateBus();

        public static void Forward(YpyfCreatedMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Forward(YpyfUpdatedMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}
