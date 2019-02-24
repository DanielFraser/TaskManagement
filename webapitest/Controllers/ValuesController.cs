using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapitest.Controllers
{
    public class ValuesController : ApiController
    {
        private static Dictionary<int, string> dict = new Dictionary<int, string>();
        private static List<string> a = new List<string>();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return a;
        }

        [Route("values/get2/{str}")]
        public string Get2(string str)
        {
            return str;
        }

        //public IHttpActionResult GetAll()
        //{
        //    if (dict.Values.Count() > 0)
        //        return Ok(dict.Values);
        //    return NotFound();
        //}

        // GET api/values/5
        public string Get(int id)
        {
            if (dict.ContainsKey(id))
                return dict[id];
            return id.ToString();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            a.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            dict.Add(id, "value"+id);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
           
        }
    }
}
