using System.ComponentModel;

namespace XCare.DMS.DataProc.Daemon
{
    internal enum DataManipulationOption
    {
        [Description("删除")] Delete = 1,
        [Description("新增")] Insert = 2,
        [Description("修改")] Update = 3
    }
}