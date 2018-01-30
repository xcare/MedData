using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Twd
{
    internal class UpdateTwdMessageConsumer : IConsumer<UpdateTwdMessage>
    {
        public Task Consume(ConsumeContext<UpdateTwdMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}