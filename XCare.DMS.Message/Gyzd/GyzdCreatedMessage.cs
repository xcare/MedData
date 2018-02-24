using XCare.DMS.Entity;

namespace XCare.DMS.Message.Gyzd
{
    public class GyzdCreatedMessage
    {
        public GyzdCreatedMessage()
        {
        }

        public GyzdCreatedMessage(YdhlGyzd gyzd)
        {
            Gyzd = gyzd;
        }

        public YdhlGyzd Gyzd { get; set; }
    }
}