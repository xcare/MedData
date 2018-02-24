using MassTransit;
using XCare.DMS.Message.Brxz;

namespace XCare.DMS.Message.Configuration.Brxz
{
    public class BrxzMessageForwarder
    {
        private static readonly IBusControl CreateBus = new BrxzCreatedMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new BrxzUpdatedMessageBusConfig().CreateBus();

        public static void Forward(BrxzCreatedMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Forward(BrxzUpdatedMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}