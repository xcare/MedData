using System.Collections.Generic;
using Dapper;
using XCare.DMS.Uploading.Utils;

namespace XCare.DMS.Uploading.Data
{
    internal class YdhlJbxxDao
    {
        public static List<long> GetAvailableZyhs()
        {
            using (var conn = DbUtil.GetDbConnection())
            {
                return conn.Query<long>(@"
SELECT  ZYH
FROM    dbo.YDHL_JBXX
WHERE   ZYZT = 0 ").AsList();
            }
        }
    }
}