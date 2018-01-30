using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Bryzxx
{
    public class UpdateBryzxxMessageConsumer : IConsumer<UpdateBryzxxMessage>
    {
        public Task Consume(ConsumeContext<UpdateBryzxxMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}