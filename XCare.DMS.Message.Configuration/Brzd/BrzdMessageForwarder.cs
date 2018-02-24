using MassTransit;
using XCare.DMS.Message.Brxz;
using XCare.DMS.Message.Brzd;
using XCare.DMS.Message.Configuration.Brxz;

namespace XCare.DMS.Message.Configuration.Brzd
{
    public class BrzdMessageForwarder
    {
        private static readonly IBusControl CreateBus = new BrzdCreatedMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new BrzdUpdatedMessageBusConfig().CreateBus();

        public static void Forward(BrzdCreatedMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Forward(BrzdUpdatedMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}