using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        EmployeeCRUDContext OBJ = new EmployeeCRUDContext();

        [HttpGet]
        public List<DepartmentMaster> GetDepatment()
        {
            List<DepartmentMaster> DATA = OBJ.DepartmentMasters.ToList();
           return DATA;
        }
    }
}
