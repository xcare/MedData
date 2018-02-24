using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Ypzd;
using XCare.DMS.Message.Ypzd;

namespace XCare.DMS.Message.Configuration.Ypzd
{
    public class YpzdCreatedMessageConsumer : IConsumer<YpzdCreatedMessage>
    {
        public Task Consume(ConsumeContext<YpzdCreatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new YpzdCreatedMessageHandler(), context);
        }
    }
}