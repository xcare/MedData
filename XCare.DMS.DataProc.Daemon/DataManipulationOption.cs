using System.ComponentModel;
using System.Xml.Serialization;

namespace XCare.DMS.DataProc.Daemon
{
    public enum DataManipulationOption
    {
        [XmlEnum("1")] [Description("删除")] Delete = 1,
        [XmlEnum("2")] [Description("新增")] Insert = 2,
        [XmlEnum("3")] [Description("修改")] Update = 3
    }
}