using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Bryzxx;
using XCare.DMS.Message.Bryzxx;

namespace XCare.DMS.Message.Configuration.Bryzxx
{
    internal class BryzxxUpdatedMessageConsumer : IConsumer<BryzxxUpdatedMessage>
    {
        public Task Consume(ConsumeContext<BryzxxUpdatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new BryzxxUpdatedMessageHandler(), context);
        }
    }
}