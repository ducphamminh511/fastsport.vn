//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fastsport.vn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class account_customer
    {
        public int ID { get; set; }
        public string login_id { get; set; }
        public string passwords { get; set; }
        public Nullable<int> customer_id { get; set; }
    
        public virtual khach_hang khach_hang { get; set; }
    }
}
