using System.Web.Http;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     药品
    /// </summary>
    public class YpController : ApiController
    {
        /// <summary>
        ///     新增药品
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        ///     修改药品
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除药品
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}