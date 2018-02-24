using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Jybg;
using XCare.DMS.Message.Jybg;

namespace XCare.DMS.Message.Configuration.Jybg
{
    public class JybgCreatedMessageConsumer : IConsumer<JybgCreatedMessage>
    {
        public Task Consume(ConsumeContext<JybgCreatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new JybgCreatedMessageHandler(), context);
        }
    }
}