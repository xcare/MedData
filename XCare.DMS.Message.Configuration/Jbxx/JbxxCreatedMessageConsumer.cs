using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Jbxx;

namespace XCare.DMS.Message.Configuration.Jbxx
{
    internal class JbxxCreatedMessageConsumer : IConsumer<JbxxCreatedMessage>
    {
        public Task Consume(ConsumeContext<JbxxCreatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}