using System.Web.Http;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     疾病编码
    /// </summary>
    public class JbbmController : ApiController
    {
        /// <summary>
        ///     新增疾病编码
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        ///     修改疾病编码
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除疾病编码
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}