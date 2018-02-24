using MassTransit;
using XCare.DMS.DataProc.MessageHandler.Jbbm;
using XCare.DMS.Message.Jbbm;

namespace XCare.DMS.Message.Configuration.Jbbm
{
    internal class JbbmCreatedMessageConsumer:IConsumer<JbbmCreatedMessage>
    {
        public System.Threading.Tasks.Task Consume(ConsumeContext<JbbmCreatedMessage> context)
        {
            return MessageHandlerHandler.Handle(new JbbmCreatedMessageHandler(), context);
        }
    }
}