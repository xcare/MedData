using System;
using System.Web.Http;
using Nelibur.ObjectMapper;
using XCare.DMS.Entity;
using XCare.DMS.Receiving.DTO;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     公用字典
    /// </summary>
    public class GyzdController : ApiController
    {
        private readonly GyzdService _gyzdService=new GyzdService();

        static GyzdController()
        {
            TinyMapper.Bind<GyzdCreationDTO, YdhlGyzd>();
        }

        /// <summary>
        ///     新增公用字典
        /// </summary>
        /// <param name="dto"></param>
        public void Post(GyzdCreationDTO dto)
        {
            var obj = TinyMapper.Map<YdhlGyzd>(dto);
            obj.Id = Guid.NewGuid();
            _gyzdService.Create(obj);
        }

        /// <summary>
        ///     修改公用字典
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除公用字典
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}