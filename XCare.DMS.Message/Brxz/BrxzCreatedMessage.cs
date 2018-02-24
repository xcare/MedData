using XCare.DMS.Entity;

namespace XCare.DMS.Message.Brxz
{
    public class BrxzCreatedMessage
    {
        public BrxzCreatedMessage()
        {
        }

        public BrxzCreatedMessage(YdhlBrxz brxz)
        {
            Brxz = brxz;
        }

        public YdhlBrxz Brxz { get; set; }
    }
}