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
    
    public partial class sp_user_readByUsernameAndPassword_Result
    {
        public int user_id { get; set; }
        public string user_username { get; set; }
        public string user_password { get; set; }
        public string user_first_name { get; set; }
        public string user_last_name { get; set; }
        public string user_gender { get; set; }
        public string user_email { get; set; }
        public string user_phone { get; set; }
        public bool user_email_verified { get; set; }
        public string user_registration_date { get; set; }
        public string user_verification_code { get; set; }
        public System.DateTime user_date_of_birth { get; set; }
        public Nullable<int> country_id { get; set; }
    }
}
