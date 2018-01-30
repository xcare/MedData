using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Jybg
{
    internal class UpdateJybgMessageConsumer : IConsumer<UpdateJybgMessage>
    {
        public Task Consume(ConsumeContext<UpdateJybgMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}