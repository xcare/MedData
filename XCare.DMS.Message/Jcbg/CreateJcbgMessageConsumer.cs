using System;
using System.Threading.Tasks;
using MassTransit;

namespace XCare.DMS.Message.Jcbg
{
    public class CreateJcbgMessageConsumer : IConsumer<CreateJcbgMessage>
    {
        public Task Consume(ConsumeContext<CreateJcbgMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}