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
    
    public partial class Mishap_for_employee
    {
        public int code { get; set; }
        public int mishap_code { get; set; }
        public string worker_id { get; set; }
        public System.DateTime start_date { get; set; }
        public System.DateTime end_date { get; set; }
    
        public virtual Mishap Mishap { get; set; }
        public virtual Worker Worker { get; set; }
    }
}