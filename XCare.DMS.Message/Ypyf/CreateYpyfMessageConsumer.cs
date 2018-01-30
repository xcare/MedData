using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Ypyf
{
    public class CreateYpyfMessageConsumer : IConsumer<CreateYpyfMessage>
    {
        public Task Consume(ConsumeContext<CreateYpyfMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}