using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Twd;

namespace XCare.DMS.Message.Configuration.Twd
{
    internal class TwdUpdatedMessageConsumer : IConsumer<TwdUpdatedMessage>
    {
        public Task Consume(ConsumeContext<TwdUpdatedMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}