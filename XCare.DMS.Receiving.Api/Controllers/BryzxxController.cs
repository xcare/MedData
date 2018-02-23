using System.Web.Http;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     病人医嘱
    /// </summary>
    public class BryzxxController : ApiController
    {
        /// <summary>
        ///     新增病人医嘱
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        ///     修改病人医嘱
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除病人医嘱
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}