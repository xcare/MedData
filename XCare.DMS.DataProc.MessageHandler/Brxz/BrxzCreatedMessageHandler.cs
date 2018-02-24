using System;
using XCare.DMS.Message.Brxz;

namespace XCare.DMS.DataProc.MessageHandler.Brxz
{
    public class BrxzCreatedMessageHandler : IMessageHandler<BrxzCreatedMessage>
    {
        public bool Handle(BrxzCreatedMessage message)
        {
            Console.WriteLine(message.Brxz.ToString());
            return true;
        }
    }
}