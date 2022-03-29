using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.NETCORE.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<string> StringDATA = new List<string>()
        {
            "Value0", "Value1", "Value2"
        };

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return StringDATA;
        }

        [HttpGet]
        public string GetEmployee(int id)
        {
            return StringDATA[id];
        }

        [HttpPost]
        public void PostEmployee(string value)
        {
            StringDATA.Add(value);
        }
        [HttpPut]
        public void PutEmployee(int id, string UpdatedName)
        {
            StringDATA[id] = UpdatedName;
        }

        [HttpDelete]
        public void DeleteEmployee(int id)
        {
            StringDATA.RemoveAt(id);
        }
    }
}
