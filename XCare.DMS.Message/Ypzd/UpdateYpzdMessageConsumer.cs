using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Ypzd
{
    internal class UpdateYpzdMessageConsumer : IConsumer<UpdateYpzdMessage>
    {
        public Task Consume(ConsumeContext<UpdateYpzdMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}