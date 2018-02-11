using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using XCare.DMS.Uploading.Utils;

namespace XCare.DMS.Uploading.Data
{
    internal class YdhlGyzdDao
    {
        public static List<string> GetZdlbs()
        {
            using (var conn = DbUtil.GetDbConnection())
                return conn.Query<string>(@"
SELECT  DMMC
FROM    dbo.YDHL_GYZD
WHERE   DMLB = 22
        AND DMSB <> 0 AND DMSB<>1").AsList();
        }
    }
}
