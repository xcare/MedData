using System.Web.Http;
using Nelibur.ObjectMapper;
using XCare.DMS.Entity;
using XCare.DMS.Receiving.DTO;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     疾病编码
    /// </summary>
    public class JbbmController : ApiController
    {
        private readonly JbbmService _jbbmService=new JbbmService();

        static JbbmController()
        {
            TinyMapper.Bind<JbbmCreationDTO, YdhlJbbm>();
        }

        /// <summary>
        ///     新增疾病编码
        /// </summary>
        /// <param name="dto"></param>
        public void Post(JbbmCreationDTO dto)
        {
            _jbbmService.Create(TinyMapper.Map<YdhlJbbm>(dto));
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