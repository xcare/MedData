using System.Web.Http;
using Nelibur.ObjectMapper;
using XCare.DMS.Entity;
using XCare.DMS.Receiving.DTO;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     病人信息
    /// </summary>
    public class JbxxController : ApiController
    {
        private readonly JbxxService _jbxxService = new JbxxService();

        static JbxxController()
        {
            TinyMapper.Bind<JbxxCreationDTO, YdhlJbxx>();
        }

        /// <summary>
        ///     新增病人
        /// </summary>
        /// <param name="dto"></param>
        public void Post(JbxxCreationDTO dto)
        {
            _jbxxService.Create(TinyMapper.Map<YdhlJbxx>(dto));
        }

        /// <summary>
        ///     修改病人
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除病人
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}