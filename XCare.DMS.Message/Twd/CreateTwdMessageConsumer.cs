using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Jybg;

namespace XCare.DMS.Message.Twd
{
    public class CreateTwdMessageConsumer : IConsumer<CreateJybgMessage>
    {
        public Task Consume(ConsumeContext<CreateJybgMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}