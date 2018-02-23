using System.Web.Http;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     体温单
    /// </summary>
    public class TwdController : ApiController
    {
        /// <summary>
        ///     新增体温单
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        ///     修改体温单
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除体温单
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}