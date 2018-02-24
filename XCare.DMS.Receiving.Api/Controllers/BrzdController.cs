using System;
using System.Web.Http;
using Nelibur.ObjectMapper;
using XCare.DMS.Entity;
using XCare.DMS.Receiving.DTO;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     病人诊断
    /// </summary>
    public class BrzdController : ApiController
    {
        private readonly BrzdService _brzdService = new BrzdService();

        private BrzdController()
        {
            TinyMapper.Bind<BrzdCreationDTO, YdhlBrzd>();
        }

        /// <summary>
        ///     新增病人诊断
        /// </summary>
        /// <param name="dto"></param>
        public void Post(BrzdCreationDTO dto)
        {
            var obj = TinyMapper.Map<YdhlBrzd>(dto);
            obj.Id = Guid.NewGuid();
            _brzdService.Create(obj);
        }

        /// <summary>
        ///     修改病人诊断
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除病人诊断
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}