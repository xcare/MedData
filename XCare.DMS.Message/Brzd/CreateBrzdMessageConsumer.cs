using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Bryzxx;

namespace XCare.DMS.Message.Brzd
{
    public class CreateBrzdMessageConsumer : IConsumer<CreateBryzxxMessage>
    {
        public Task Consume(ConsumeContext<CreateBryzxxMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}