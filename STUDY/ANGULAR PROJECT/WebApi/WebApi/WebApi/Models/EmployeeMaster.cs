using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models
{
    public partial class EmployeeMaster
    {
        public EmployeeMaster()
        {
            EmployeeShiftRelationships = new HashSet<EmployeeShiftRelationship>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isactive { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? Salary { get; set; }

        public virtual DepartmentMaster Department { get; set; }
        public virtual ICollection<EmployeeShiftRelationship> EmployeeShiftRelationships { get; set; }
    }
}
