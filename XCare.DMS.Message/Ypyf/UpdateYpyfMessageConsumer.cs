using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Ypyf
{
    internal class UpdateYpyfMessageConsumer : IConsumer<UpdateYpyfMessage>
    {
        public Task Consume(ConsumeContext<UpdateYpyfMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}