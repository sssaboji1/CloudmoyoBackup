//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeMaster()
        {
            this.EmployeeShiftRelationships = new HashSet<EmployeeShiftRelationship>();
        }
    
    
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> Modifieddate { get; set; }
        public Nullable<bool> Isactive { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public virtual DepartmentMaster DepartmentMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeShiftRelationship> EmployeeShiftRelationships { get; set; }
    }
}
