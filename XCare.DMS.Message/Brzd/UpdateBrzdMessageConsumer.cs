using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Brzd
{
    public class UpdateBrzdMessageConsumer : IConsumer<UpdateBrzdMessage>
    {
        public Task Consume(ConsumeContext<UpdateBrzdMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}