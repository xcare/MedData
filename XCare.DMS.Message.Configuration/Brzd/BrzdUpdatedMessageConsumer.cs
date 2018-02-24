using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Brzd;
using XCare.DMS.Message.Brzd;

namespace XCare.DMS.Message.Configuration.Brzd
{
    internal class BrzdUpdatedMessageConsumer : IConsumer<BrzdUpdatedMessage>
    {
        public Task Consume(ConsumeContext<BrzdUpdatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new BrzdUpdatedMessageHandler(), context);
        }
    }
}