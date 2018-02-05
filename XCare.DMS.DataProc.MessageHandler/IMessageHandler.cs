namespace XCare.DMS.DataProc.MessageHandler
{
    public interface IMessageHandler<in T> where T : class, new()
    {
        bool Handle(T message);
    }
}