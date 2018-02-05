using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace XCare.DMS.Receiving.Api.Controllers
{
    public class GyzdController : ApiController
    {
        // GET api/gyzd
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/gyzd/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/gyzd
        public void Post([FromBody]string value)
        {
        }

        // PUT api/gyzd/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/gyzd/5
        public void Delete(int id)
        {
        }
    }
}
