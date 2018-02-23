using System.Web.Http;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     公用字典
    /// </summary>
    public class GyzdController : ApiController
    {
        /// <summary>
        ///     新增公用字典
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        ///     修改公用字典
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除公用字典
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}