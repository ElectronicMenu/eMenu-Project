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
    
    public partial class cart
    {
        public int cart_id { get; set; }
        public int table_id { get; set; }
        public int user_id { get; set; }
        public string cart_date { get; set; }
    
        public virtual table table { get; set; }
    }
}
