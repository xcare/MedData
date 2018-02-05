using System;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.DataProc.MessageHandler;

namespace XCare.DMS.Message.Configuration
{
    public class MessageHandlerHandler
    {
        private static readonly TimeSpan RedeliverInterval = TimeSpan.FromSeconds(30);

        public static Task Handle<T>(IMessageHandler<T> handler, ConsumeContext<T> context) where T : class, new()
        {
            try
            {
                return handler.Handle(context.Message)
                    ? Task.CompletedTask
                    : context.Redeliver(RedeliverInterval);
            }
            catch (Exception)
            {
                return context.Redeliver(RedeliverInterval);
            }
        }
    }
}