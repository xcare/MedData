using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Jcbg;
using XCare.DMS.Message.Jcbg;

namespace XCare.DMS.Message.Configuration.Jcbg
{
    internal class JcbgUpdatedMessageConsumer : IConsumer<JcbgUpdatedMessage>
    {
        public Task Consume(ConsumeContext<JcbgUpdatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new JcbgUpdatedMessageHandler(), context);
        }
    }
}