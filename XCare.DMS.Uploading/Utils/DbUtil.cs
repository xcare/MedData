using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace XCare.DMS.Uploading.Utils
{
    internal static class DbUtil
    {
        private static readonly string XCareHisConnectionString = ConfigurationManager.AppSettings["XCareHisConnectionString"];

        public static IDbConnection GetDbConnection()
        {
            return new SqlConnection(XCareHisConnectionString);
        }
    }
}