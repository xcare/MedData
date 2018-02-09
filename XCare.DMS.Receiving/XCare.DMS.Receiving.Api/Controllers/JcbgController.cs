using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace XCare.DMS.Receiving.Api.Controllers
{
    public class JcbgController : ApiController
    {
        // GET api/jcbg
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/jcbg/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/jcbg
        public void Post([FromBody]string value)
        {
        }

        // PUT api/jcbg/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/jcbg/5
        public void Delete(int id)
        {
        }
    }
}
