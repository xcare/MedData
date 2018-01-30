using MassTransit;

namespace XCare.DMS.Message.Bryzxx
{
    public class BryzxMessagePublisher
    {
        private static readonly IBusControl CreateBus = new CreateBryzxxMessageBusConfig().CreateBus();
        private static readonly IBusControl UpdateBus = new UpdateBryzxxMessageBusConfig().CreateBus();

        public static void Publish(CreateBryzxxMessage message)
        {
            CreateBus.Publish(message);
        }

        public static void Publish(UpdateBryzxxMessage message)
        {
            UpdateBus.Publish(message);
        }
    }
}