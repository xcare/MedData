using System.Collections.Generic;
using Dapper;
using XCare.DMS.Uploading.Utils;

namespace XCare.DMS.Uploading.Data
{
    internal class YdhlJbbmDao
    {
        public static List<string> LoadJbmcs()
        {
            using (var conn = DbUtil.GetDbConnection())
            {
                return conn.Query<string>(@"SELECT NAME FROM dbo.YDHL_JBBM").AsList();
            }
        }
    }
}