using System;
using System.Web.Http;
using Nelibur.ObjectMapper;
using XCare.DMS.Entity;
using XCare.DMS.Receiving.DTO;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     药品
    /// </summary>
    public class YpController : ApiController
    {
        private readonly YpzdService _ypzdService = new YpzdService();

        static YpController()
        {
            TinyMapper.Bind<YpzdCreationDTO, YdhlYpzd>();
        }

        /// <summary>
        ///     新增药品
        /// </summary>
        /// <param name="dto"></param>
        public void Post(YpzdCreationDTO dto)
        {
            var obj = TinyMapper.Map<YdhlYpzd>(dto);
            obj.Id = Guid.NewGuid();
            _ypzdService.Create(obj);
        }

        /// <summary>
        ///     修改药品
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除药品
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}