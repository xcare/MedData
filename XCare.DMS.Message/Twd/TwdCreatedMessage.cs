using System.Collections.Generic;
using XCare.DMS.Entity;

namespace XCare.DMS.Message.Twd
{
    public class TwdCreatedMessage
    {
        public TwdCreatedMessage(){}

        public TwdCreatedMessage(IEnumerable<YdhlTwd> twds)
        {
            Twds = twds;
        }
        public IEnumerable<YdhlTwd> Twds { get; set; }
    }
}