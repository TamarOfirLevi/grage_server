//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GarageDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Worker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Worker()
        {
            this.Mishap_for_employee = new HashSet<Mishap_for_employee>();
        }
    
        public int id_worker { get; set; }
        public Nullable<int> num_of_credits { get; set; }
        public int employee_kind_code { get; set; }
        public string id_user { get; set; }
    
        public virtual Employee_kind Employee_kind { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mishap_for_employee> Mishap_for_employee { get; set; }
        public virtual User User { get; set; }
    }
}
