﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using XCare.DMS.Uploading.Utils;

namespace XCare.DMS.Uploading.Data
{
    class YdhlYpzdDao
    {
        public static List<string> LoadYpmcs()
        {
            using (var conn = DbUtil.GetDbConnection())
                return conn.Query<string>(@"SELECT DISTINCT YPMC FROM dbo.YDHL_YPZD").AsList();
        }
    }
}
