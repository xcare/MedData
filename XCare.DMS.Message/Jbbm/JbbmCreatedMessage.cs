using XCare.DMS.Entity;

namespace XCare.DMS.Message.Jbbm
{
    public class JbbmCreatedMessage
    {
        public JbbmCreatedMessage()
        {
        }

        public JbbmCreatedMessage(YdhlJbbm jbbm)
        {
            Jbbm = jbbm;
        }

        public YdhlJbbm Jbbm { get; set; }
    }
}