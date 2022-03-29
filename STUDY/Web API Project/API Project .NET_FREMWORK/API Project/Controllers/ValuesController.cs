using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Project.Controllers
{
    public class ValuesController : ApiController
    {
       static List<string> StringData = new List<string>()
       {
          "Value0", "Value1", "Value3"
       };
        // GET api/values
        public IEnumerable<string> Get()
        {
        return StringData;
        }

        // GET api/values/5
        public string Get(int id)
        {
            string A = StringData[id];

            return A;

        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            StringData.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, string value)
        {
            StringData[id]=value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            StringData.RemoveAt(id);
        }
    }
}
