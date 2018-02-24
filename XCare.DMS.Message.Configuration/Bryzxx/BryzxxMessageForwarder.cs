using MassTransit;
using XCare.DMS.Message.Bryzxx;

namespace XCare.DMS.Message.Configuration.Bryzxx
{
    public class BryzxxMessageForwarder
    {
        private static readonly IBusControl CreateBus = new BryzxxCreatedMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new BryzxxUpdatedMessageBusConfig().CreateBus();

        public static void Forward(BryzxxCreatedMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Forward(BryzxxUpdatedMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}