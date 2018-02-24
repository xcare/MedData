using System;
using System.Web.Http;
using Nelibur.ObjectMapper;
using XCare.DMS.Entity;
using XCare.DMS.Receiving.DTO;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     药品用法
    /// </summary>
    public class YpyfController : ApiController
    {
        private readonly YpyfService _ypyfService = new YpyfService();

        static YpyfController()
        {
            TinyMapper.Bind<YpyfCreationDTO, YdhlYpyf>();
        }

        /// <summary>
        ///     新增药品用法
        /// </summary>
        /// <param name="dto"></param>
        public void Post(YpyfCreationDTO dto)
        {
            var obj = TinyMapper.Map<YdhlYpyf>(dto);
            obj.Id = Guid.NewGuid();
            _ypyfService.Create(obj);
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