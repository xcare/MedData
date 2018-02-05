using MassTransit;
using XCare.DMS.Message.Jbbm;

namespace XCare.DMS.Message.Configuration.Jbbm
{
    internal class JbbmUpdatedMessageConsumer:IConsumer<JbbmUpdatedMessage>
    {
        public System.Threading.Tasks.Task Consume(ConsumeContext<JbbmUpdatedMessage> context)
        {
            throw new System.NotImplementedException();
        }
    }
}