using System.Web.Http;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     药品用法
    /// </summary>
    public class YpyfController : ApiController
    {
        /// <summary>
        ///     新增药品用法
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        ///     修改药品用法
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除药品用法
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}