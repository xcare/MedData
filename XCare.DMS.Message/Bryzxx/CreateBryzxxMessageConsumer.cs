using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Bryzxx
{
    public class CreateBryzxxMessageConsumer : IConsumer<CreateBryzxxMessage>
    {
        public Task Consume(ConsumeContext<CreateBryzxxMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}