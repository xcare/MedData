using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Brxz;

namespace XCare.DMS.Message.Configuration.Brxz
{
    internal class BrxzUpdatedMessageConsumer : IConsumer<BrxzUpdatedMessage>
    {
        public Task Consume(ConsumeContext<BrxzUpdatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}