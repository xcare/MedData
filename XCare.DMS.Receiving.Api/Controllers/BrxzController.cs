using System;
using System.Web.Http;
using Nelibur.ObjectMapper;
using XCare.DMS.Entity;
using XCare.DMS.Receiving.DTO;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     病人性质
    /// </summary>
    public class BrxzController : ApiController
    {
        private readonly BrxzService _brxzService = new BrxzService();

        static BrxzController()
        {
            TinyMapper.Bind<BrxzCreationDTO, YdhlBrxz>();
        }

        /// <summary>
        ///     新增病人性质
        /// </summary>
        /// <param name="dto"></param>
        public void Post(BrxzCreationDTO dto)
        {
            var obj = TinyMapper.Map<YdhlBrxz>(dto);
            obj.Id = Guid.NewGuid();
            _brxzService.Create(obj);
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