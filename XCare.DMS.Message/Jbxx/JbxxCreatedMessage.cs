using XCare.DMS.Entity;

namespace XCare.DMS.Message.Jbxx
{
    public class JbxxCreatedMessage
    {
        public JbxxCreatedMessage()
        {
        }

        public JbxxCreatedMessage(YdhlJbxx jbxx)
        {
            Jbxx = jbxx;
        }

        public YdhlJbxx Jbxx { get; set; }
    }
}