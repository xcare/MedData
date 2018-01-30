using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Jbxx
{
    public class CreateJbxxMessageConsumer : IConsumer<CreateJbxxMessage>
    {
        public Task Consume(ConsumeContext<CreateJbxxMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}