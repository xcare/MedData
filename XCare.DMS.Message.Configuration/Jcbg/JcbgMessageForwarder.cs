using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Configuration.Jbxx;
using XCare.DMS.Message.Jbxx;
using XCare.DMS.Message.Jcbg;

namespace XCare.DMS.Message.Configuration.Jcbg
{
    public class JcbgMessageForwarder
    {
        private static readonly IBusControl CreateBus = new JcbgCreatedMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new JcbgUpdatedMessageBusConfig().CreateBus();

        public static void Forward(JcbgCreatedMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Forward(JcbgUpdatedMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}
