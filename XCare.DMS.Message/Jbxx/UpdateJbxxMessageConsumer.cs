using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Jbxx
{
    internal class UpdateJbxxMessageConsumer : IConsumer<UpdateJbxxMessage>
    {
        public Task Consume(ConsumeContext<UpdateJbxxMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}