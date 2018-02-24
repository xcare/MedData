using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Gyzd;
using XCare.DMS.Message.Gyzd;

namespace XCare.DMS.Message.Configuration.Gyzd
{
    internal class GyzdCreatedMessageConsumer : IConsumer<GyzdCreatedMessage>
    {
        public Task Consume(ConsumeContext<GyzdCreatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new GyzdCreatedMessageHandler(), context);
        }
    }
}