using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Jbxx;
using XCare.DMS.Message.Jbxx;

namespace XCare.DMS.Message.Configuration.Jbxx
{
    internal class JbxxUpdatedMessageConsumer : IConsumer<JbxxUpdatedMessage>
    {
        public Task Consume(ConsumeContext<JbxxUpdatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new JbxxUpdatedMessageHandler(), context);
        }
    }
}