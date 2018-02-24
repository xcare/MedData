using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Brxz;
using XCare.DMS.Message.Brxz;

namespace XCare.DMS.Message.Configuration.Brxz
{
    internal class BrxzUpdatedMessageConsumer : IConsumer<BrxzUpdatedMessage>
    {
        public Task Consume(ConsumeContext<BrxzUpdatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new BrxzUpdatedMessageHandler(), context);
        }
    }
}