using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Twd;
using XCare.DMS.Message.Jybg;
using XCare.DMS.Message.Twd;

namespace XCare.DMS.Message.Configuration.Twd
{
    public class TwdCreatedMessageConsumer : IConsumer<TwdCreatedMessage>
    {

        public Task Consume(ConsumeContext<TwdCreatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new TwdCreatedMessageHandler(), context);
        }
    }
}