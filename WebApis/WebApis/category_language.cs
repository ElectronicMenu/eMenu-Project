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
    
    public partial class category_language
    {
        public int category_id { get; set; }
        public int language_id { get; set; }
        public string category_name { get; set; }
    
        public virtual category category { get; set; }
        public virtual language language { get; set; }
    }
}
