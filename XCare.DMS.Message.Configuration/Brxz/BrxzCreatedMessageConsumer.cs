using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Brxz;

namespace XCare.DMS.Message.Configuration.Brxz
{
    internal class BrxzCreatedMessageConsumer : IConsumer<BrxzCreatedMessage>
    {
        public Task Consume(ConsumeContext<BrxzCreatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}