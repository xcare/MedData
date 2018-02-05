using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Ypyf;

namespace XCare.DMS.Message.Configuration.Ypyf
{
    public class YpyfCreatedMessageConsumer : IConsumer<YpyfCreatedMessage>
    {
        public Task Consume(ConsumeContext<YpyfCreatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}