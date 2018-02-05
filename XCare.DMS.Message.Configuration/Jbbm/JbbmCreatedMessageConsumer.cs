using MassTransit;
using XCare.DMS.Message.Jbbm;

namespace XCare.DMS.Message.Configuration.Jbbm
{
    internal class JbbmCreatedMessageConsumer:IConsumer<JbbmCreatedMessage>
    {
        public System.Threading.Tasks.Task Consume(ConsumeContext<JbbmCreatedMessage> context)
        {
            throw new System.NotImplementedException();
        }
    }
}