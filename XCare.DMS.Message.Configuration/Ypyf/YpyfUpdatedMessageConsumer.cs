using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Ypyf;
using XCare.DMS.Message.Ypyf;

namespace XCare.DMS.Message.Configuration.Ypyf
{
    internal class YpyfUpdatedMessageConsumer : IConsumer<YpyfUpdatedMessage>
    {
        public Task Consume(ConsumeContext<YpyfUpdatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new YpyfUpdatedMessageHandler(), context);
        }
    }
}