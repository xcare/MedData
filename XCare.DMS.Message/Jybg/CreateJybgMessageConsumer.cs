using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Jybg
{
    public class CreateJybgMessageConsumer : IConsumer<CreateJybgMessage>
    {
        public Task Consume(ConsumeContext<CreateJybgMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}