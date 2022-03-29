using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace API_Project.Controllers
{
    public class EmployeeController : ApiController
    {
        Employee_CRUDEntities ObjEntities = new Employee_CRUDEntities();
        [HttpGet]
        public IEnumerable<EmployeeMaster> GetAll()

        {
            //return ObjEntities.EmployeeMasters.ToList();

            var a = (from s in ObjEntities.EmployeeMasters.ToList()
                     select new EmployeeMaster
                     {
                         EmployeeID = s.EmployeeID,
                         FirstName = s.FirstName,
                         LastName = s.LastName,
                         City = s.City,
                         CreatedDate = s.CreatedDate,
                         Modifieddate = s.Modifieddate,
                         Salary = s.Salary,
                         DepartmentID = s.DepartmentID,
                         DepartmentMaster =s.DepartmentMaster
                     }).ToList();

            return a;
        }

        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var b = ObjEntities.EmployeeMasters.FirstOrDefault(e => e.EmployeeID == id);
            if (b != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, b);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with ID = " + id.ToString() + " Not found");
            }
        }

        [HttpPost]
        public HttpResponseMessage post([FromBody] EmployeeMaster employee)
        {
            try
            {

                ObjEntities.EmployeeMasters.Add(employee);
                ObjEntities.SaveChanges();
                var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                message.Headers.Location = new Uri(Request.RequestUri + employee.EmployeeID.ToString());
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var c = ObjEntities.EmployeeMasters.FirstOrDefault(e => e.EmployeeID == id);
                if (c != null)
                {
                    ObjEntities.EmployeeMasters.Remove(c);
                    ObjEntities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, id);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee ID with = " + id.ToString() + " not fount to delete");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]EmployeeMaster employee)
        {
            var d = ObjEntities.EmployeeMasters.FirstOrDefault(e => e.EmployeeID == id);
            try
            {
                if (d != null)
                {

                    d.FirstName = employee.FirstName;
                    d.LastName = employee.LastName;
                    d.City = employee.City;
                    d.Isactive = employee.Isactive;
                    d.Modifieddate = employee.Modifieddate;
                    d.Salary = employee.Salary;
                    d.DepartmentID = employee.DepartmentID;

                    ObjEntities.SaveChanges();

                    return Request.CreateResponse(HttpStatusCode.OK,id);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with id " + id.ToString() + " not found");
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}


