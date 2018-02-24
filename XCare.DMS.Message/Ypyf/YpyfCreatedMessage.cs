using XCare.DMS.Entity;

namespace XCare.DMS.Message.Ypyf
{
    public class YpyfCreatedMessage
    {
        public YpyfCreatedMessage(){}

        public YpyfCreatedMessage(YdhlYpyf ypyf)
        {
            Ypyf = ypyf;
        }

        public YdhlYpyf Ypyf { get; set; }
    }
}