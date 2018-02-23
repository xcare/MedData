using System.Web.Http;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     病人性质
    /// </summary>
    public class BrxzController : ApiController
    {
        /// <summary>
        ///     新增病人性质
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        ///     修改病人性质
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除病人性质
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}