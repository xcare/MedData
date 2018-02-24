using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Nelibur.ObjectMapper;
using XCare.DMS.Entity;
using XCare.DMS.Receiving.DTO;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     检查报告
    /// </summary>
    public class JcbgController : ApiController
    {
        private readonly JcbgService _jcbgService = new JcbgService();

        static JcbgController()
        {
            TinyMapper.Bind<JcbgCreationDTO, YdhlJcbg>();
        }

        /// <summary>
        ///     新增检查报告
        /// </summary>
        /// <param name="dtos"></param>
        public void Post(IEnumerable<JcbgCreationDTO> dtos)
        {
            _jcbgService.Create(dtos.Select(e =>
            {
                var obj = TinyMapper.Map<YdhlJcbg>(e);
                obj.Id = Guid.NewGuid();
                return obj;
            }));
        }

        /// <summary>
        ///     修改检查报告
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除检查报告
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}