//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApis
{
    using System;
    using System.Collections.Generic;
    
    public partial class table
    {
        public table()
        {
            this.carts = new HashSet<cart>();
            this.orders = new HashSet<order>();
        }
    
        public int table_id { get; set; }
        public int table_number { get; set; }
        public string table_password { get; set; }
        public bool table_is_occupied { get; set; }
    
        public virtual ICollection<cart> carts { get; set; }
        public virtual ICollection<order> orders { get; set; }
    }
}
