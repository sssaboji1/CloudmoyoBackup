using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models
{
    public partial class DepartmentMaster
    {
        public DepartmentMaster()
        {
            EmployeeMasters = new HashSet<EmployeeMaster>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<EmployeeMaster> EmployeeMasters { get; set; }
    }
}
