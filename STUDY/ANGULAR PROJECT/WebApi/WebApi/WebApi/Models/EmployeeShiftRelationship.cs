using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models
{
    public partial class EmployeeShiftRelationship
    {
        public int RelationshipId { get; set; }
        public int? EmployeeId { get; set; }
        public int? ShiftId { get; set; }

        public virtual EmployeeMaster Employee { get; set; }
        public virtual ShiftMaster Shift { get; set; }
    }
}
