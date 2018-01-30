using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Gyzd
{
    public class CreateGyzdMessageConsumer : IConsumer<CreateGyzdMessage>
    {
        public Task Consume(ConsumeContext<CreateGyzdMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}