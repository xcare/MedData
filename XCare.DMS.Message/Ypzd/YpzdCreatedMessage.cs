using XCare.DMS.Entity;

namespace XCare.DMS.Message.Ypzd
{
    public class YpzdCreatedMessage
    {
        public YpzdCreatedMessage(){}

        public YpzdCreatedMessage(YdhlYpzd yp)
        {
            Yp = yp;
        }
        public YdhlYpzd Yp { get; set; }
    }
}