using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Bryzxx;

namespace XCare.DMS.Message.Configuration.Brzd
{
    internal class BrzdCreatedMessageConsumer : IConsumer<BryzxxCreatedMessage>
    {
        public Task Consume(ConsumeContext<BryzxxCreatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}