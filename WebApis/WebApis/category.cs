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
    
    public partial class category
    {
        public category()
        {
            this.category_language = new HashSet<category_language>();
        }
    
        public int category_id { get; set; }
        public string category_image { get; set; }
        public string category_icon { get; set; }
    
        public virtual ICollection<category_language> category_language { get; set; }
    }
}