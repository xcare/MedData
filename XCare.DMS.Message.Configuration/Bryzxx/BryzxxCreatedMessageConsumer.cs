using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Bryzxx;
using XCare.DMS.Message.Bryzxx;

namespace XCare.DMS.Message.Configuration.Bryzxx
{
    internal class BryzxxCreatedMessageConsumer : IConsumer<BryzxxCreatedMessage>
    {
        public Task Consume(ConsumeContext<BryzxxCreatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new BryzxxCreatedMessageHandler(), context);
        }
    }
}