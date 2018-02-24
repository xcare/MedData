using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Brzd;
using XCare.DMS.Message.Bryzxx;
using XCare.DMS.Message.Brzd;

namespace XCare.DMS.Message.Configuration.Brzd
{
    internal class BrzdCreatedMessageConsumer : IConsumer<BrzdCreatedMessage>
    {

        public Task Consume(ConsumeContext<BrzdCreatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new BrzdCreatedMessageHandler(), context);
        }
    }
}