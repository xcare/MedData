using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Ypzd;
using XCare.DMS.Message.Ypzd;

namespace XCare.DMS.Message.Configuration.Ypzd
{
    internal class YpzdUpdatedMessageConsumer : IConsumer<YpzdUpdatedMessage>
    {
        public Task Consume(ConsumeContext<YpzdUpdatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new YpzdUpdatedMessageHandler(), context);
        }
    }
}