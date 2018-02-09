using System.Xml.Linq;

namespace XCare.DMS.DataProc.Daemon.Extension
{
    public static class XElementExtension
    {
        public static string TryGetValue(this XElement element, string defaultValue = null)
        {
            return element == null ? defaultValue : element.Value;
        }
    }
}