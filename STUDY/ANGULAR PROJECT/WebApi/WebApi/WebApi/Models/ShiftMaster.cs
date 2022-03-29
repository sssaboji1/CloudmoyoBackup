using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models
{
    public partial class ShiftMaster
    {
        public ShiftMaster()
        {
            EmployeeShiftRelationships = new HashSet<EmployeeShiftRelationship>();
        }

        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public string ShiftStartTime { get; set; }
        public string ShiftEndTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? Modifieddate { get; set; }
        public bool? Isactive { get; set; }

        public virtual ICollection<EmployeeShiftRelationship> EmployeeShiftRelationships { get; set; }
    }
}
