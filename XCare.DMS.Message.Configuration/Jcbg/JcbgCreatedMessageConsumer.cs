using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Jcbg;
using XCare.DMS.Message.Jcbg;

namespace XCare.DMS.Message.Configuration.Jcbg
{
    public class JcbgCreatedMessageConsumer : IConsumer<JcbgCreatedMessage>
    {
        public Task Consume(ConsumeContext<JcbgCreatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new JcbgCreatedMessageHandler(), context);
        }
    }
}