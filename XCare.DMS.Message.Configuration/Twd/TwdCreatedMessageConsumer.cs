using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Jybg;

namespace XCare.DMS.Message.Configuration.Twd
{
    public class TwdCreatedMessageConsumer : IConsumer<JybgCreatedMessage>
    {
        public Task Consume(ConsumeContext<JybgCreatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}