using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Jcbg
{
    internal class UpdateJcbgMessageConsumer : IConsumer<UpdateJcbgMessage>
    {
        public Task Consume(ConsumeContext<UpdateJcbgMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}