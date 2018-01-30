using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Ypzd
{
    public class CreateYpzdMessageConsumer : IConsumer<CreateYpzdMessage>
    {
        public Task Consume(ConsumeContext<CreateYpzdMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}