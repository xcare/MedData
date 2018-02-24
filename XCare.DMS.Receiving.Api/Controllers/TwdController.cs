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
    ///     体温单
    /// </summary>
    public class TwdController : ApiController
    {
        private readonly TwdService _twdService = new TwdService();

        static TwdController()
        {
            TinyMapper.Bind<TwdCreationDTO, YdhlTwd>();
        }

        /// <summary>
        ///     新增体温单
        /// </summary>
        /// <param name="dtos"></param>
        public void Post(IEnumerable<TwdCreationDTO> dtos)
        {
            var objs = dtos.Select(e =>
            {
                var obj = TinyMapper.Map<YdhlTwd>(e);
                obj.Id = Guid.NewGuid();
                return obj;
            });
            _twdService.Create(objs);
        }

        /// <summary>
        ///     修改体温单
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除体温单
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}