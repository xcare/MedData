using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Jybg;

namespace XCare.DMS.Message.Configuration.Jybg
{
    internal class JybgUpdatedMessageConsumer : IConsumer<JybgUpdatedMessage>
    {
        public Task Consume(ConsumeContext<JybgUpdatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}