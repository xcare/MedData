using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Configuration.Jbbm;
using XCare.DMS.Message.Jbbm;
using XCare.DMS.Message.Jbxx;

namespace XCare.DMS.Message.Configuration.Jbxx
{
    public class JbxxMessageForwarder
    {
        private static readonly IBusControl CreateBus = new JbxxCreatedMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new JbxxUpdatedMessageBusConfig().CreateBus();

        public static void Forward(JbxxCreatedMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Forward(JbxxUpdatedMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}
