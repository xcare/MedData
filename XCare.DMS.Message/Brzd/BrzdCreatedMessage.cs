using XCare.DMS.Entity;

namespace XCare.DMS.Message.Brzd
{
    public class BrzdCreatedMessage
    {
        public BrzdCreatedMessage()
        {
        }

        public BrzdCreatedMessage(YdhlBrzd brzd)
        {
            Brzd = brzd;
        }

        public YdhlBrzd Brzd { get; set; }
    }
}