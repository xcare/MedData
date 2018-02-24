using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Nelibur.ObjectMapper;
using XCare.DMS.Entity;
using XCare.DMS.Receiving.DTO;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     病人医嘱
    /// </summary>
    public class BryzxxController : ApiController
    {
        private readonly BryzxxService _bryzxxService = new BryzxxService();
        static BryzxxController()
        {
            TinyMapper.Bind<BryzxxCreationDTO, YdhlBryzxx>();
        }

        /// <summary>
        ///     新增病人医嘱
        /// </summary>
        /// <param name="dtos"></param>
        public void Post(IEnumerable<BryzxxCreationDTO> dtos )
        {
            _bryzxxService.Create(dtos.Select(TinyMapper.Map<YdhlBryzxx>));
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