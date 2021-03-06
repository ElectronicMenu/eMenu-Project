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
    
    public partial class product
    {
        public product()
        {
            this.product_language = new HashSet<product_language>();
            this.cart_product = new HashSet<cart_product>();
            this.order_details = new HashSet<order_details>();
        }
    
        public int product_id { get; set; }
        public string product_image { get; set; }
        public bool product_is_veg { get; set; }
        public bool product_is_active { get; set; }
        public double product_price { get; set; }
        public int product_discount_type { get; set; }
        public double product_discount { get; set; }
        public Nullable<double> product_final_price { get; set; }
        public int category_id { get; set; }
    
        public virtual category category { get; set; }
        public virtual ICollection<product_language> product_language { get; set; }
        public virtual ICollection<cart_product> cart_product { get; set; }
        public virtual ICollection<order_details> order_details { get; set; }
    }
}
