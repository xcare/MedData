using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Gyzd
{
    internal class UpdateGyzdMessageConsumer : IConsumer<UpdateGyzdMessage>
    {
        public Task Consume(ConsumeContext<UpdateGyzdMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}