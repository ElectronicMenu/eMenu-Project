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
    
    public partial class tax
    {
        public tax()
        {
            this.orders = new HashSet<order>();
        }
    
        public int tax_id { get; set; }
        public double tax_percentage { get; set; }
    
        public virtual ICollection<order> orders { get; set; }
    }
}