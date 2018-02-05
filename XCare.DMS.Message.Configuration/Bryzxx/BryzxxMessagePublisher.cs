using MassTransit;
using XCare.DMS.Message.Bryzxx;

namespace XCare.DMS.Message.Configuration.Bryzxx
{
    public class BryzxxMessagePublisher
    {
        private static readonly IBusControl CreateBus = new BryzxxCreatedMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new BryzxxUpdatedMessageBusConfig().CreateBus();

        public static void Publish(BryzxxCreatedMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Publish(BryzxxUpdatedMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}