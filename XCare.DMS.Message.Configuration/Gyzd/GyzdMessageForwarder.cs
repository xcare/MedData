using MassTransit;
using XCare.DMS.Message.Brzd;
using XCare.DMS.Message.Configuration.Brzd;
using XCare.DMS.Message.Gyzd;

namespace XCare.DMS.Message.Configuration.Gyzd
{
    public class GyzdMessageForwarder
    {
        private static readonly IBusControl CreateBus = new GyzdCreatedMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new GyzdUpdatedMessageBusConfig().CreateBus();

        public static void Forward(GyzdCreatedMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Forward(GyzdUpdatedMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}