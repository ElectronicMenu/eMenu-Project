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
    
    public partial class sp_cart_product_product_readByCartIDAndLanguageID_Result
    {
        public string product_name { get; set; }
        public string product_description { get; set; }
        public string product_image { get; set; }
        public bool product_is_veg { get; set; }
        public bool product_is_active { get; set; }
        public double product_price { get; set; }
        public int product_discount_type { get; set; }
        public double product_discount { get; set; }
        public Nullable<double> product_final_price { get; set; }
        public int quantity { get; set; }
        public Nullable<int> total { get; set; }
    }
}
