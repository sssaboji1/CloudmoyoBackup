using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace API_Project.Controllers
{
    public class DepartmentController : ApiController
    {
        Employee_CRUDEntities ObjEntitie = new Employee_CRUDEntities();

        [HttpGet]
        public IEnumerable<DepartmentMaster> GetAllDepartment()
        {
            //return ObjEntitie.DepartmentMasters.ToList();
            var a = (from b in ObjEntitie.DepartmentMasters.ToList()
                     select new DepartmentMaster
                     {
                         DepartmentID = b.DepartmentID,
                         DepartmentName = b.DepartmentName

                     }).ToList();
            return a;
        }
        [HttpGet]
        public HttpResponseMessage GetDepartment(int id)
        {
             var s= ObjEntitie.DepartmentMasters.FirstOrDefault(d => d.DepartmentID == id);
            try
            {
                if (s != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, id);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Department Id " +id.ToString() + " not found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        public HttpResponseMessage AddDepartment([FromBody] DepartmentMaster department)
        {
           
            try
            {
                ObjEntitie.DepartmentMasters.Add(department);
                ObjEntitie.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created, department);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
           
        }
        [HttpDelete]
        public HttpResponseMessage DeleteDepartment(int id)
        {
            try
            {
                var a = ObjEntitie.DepartmentMasters.FirstOrDefault(d=>d.DepartmentID==id);
                if (a != null)
                {
                    ObjEntitie.DepartmentMasters.Remove(a);
                    ObjEntitie.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, id);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Department Id "+id.ToString()+ " not found to delete");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPut]
        public HttpResponseMessage PutDepatment(int id, [FromBody]DepartmentMaster department)
        {
            var m = ObjEntitie.DepartmentMasters.FirstOrDefault(d => d.DepartmentID == id);
            try
            {
                if (m != null)
                {
                    m.DepartmentName = department.DepartmentName;
                    ObjEntitie.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK,id);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Department with id" + id.ToString() + "not found");
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
