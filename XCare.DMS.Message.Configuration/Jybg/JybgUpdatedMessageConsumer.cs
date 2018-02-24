using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Jybg;
using XCare.DMS.Message.Jybg;

namespace XCare.DMS.Message.Configuration.Jybg
{
    internal class JybgUpdatedMessageConsumer : IConsumer<JybgUpdatedMessage>
    {
        public Task Consume(ConsumeContext<JybgUpdatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new JybgUpdatedMessageHandler(), context);
        }
    }
}