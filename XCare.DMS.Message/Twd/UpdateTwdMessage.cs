using System.Collections.Generic;
using XCare.DMS.Entity;

namespace XCare.DMS.Message.Twd
{
    internal class UpdateTwdMessage
    {
        public List<YdhlTwd> Twds { get; set; }
    }
}