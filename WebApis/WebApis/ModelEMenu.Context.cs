﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class hd_emenuEntities : DbContext
    {
        public hd_emenuEntities()
            : base("name=hd_emenuEntities")
        {
            Database.Connection.ConnectionString = Database.Connection.ConnectionString.Replace("**********", "password");
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<table> tables { get; set; }
        public virtual DbSet<language> languages { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<category_language> category_language { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<product_language> product_language { get; set; }
        public virtual DbSet<cart> carts { get; set; }
        public virtual DbSet<cart_product> cart_product { get; set; }
        public virtual DbSet<user> users { get; set; }
    
        public virtual ObjectResult<sp_language_readAll_Result> sp_language_readAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_language_readAll_Result>("sp_language_readAll");
        }
    
        public virtual ObjectResult<sp_language_readAllActive_Result> sp_language_readAllActive()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_language_readAllActive_Result>("sp_language_readAllActive");
        }
    
        public virtual ObjectResult<sp_language_readByID_Result> sp_language_readByID(Nullable<int> language_id)
        {
            var language_idParameter = language_id.HasValue ?
                new ObjectParameter("language_id", language_id) :
                new ObjectParameter("language_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_language_readByID_Result>("sp_language_readByID", language_idParameter);
        }
    
        public virtual ObjectResult<sp_table_readAll_Result> sp_table_readAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_table_readAll_Result>("sp_table_readAll");
        }
    
        public virtual ObjectResult<sp_table_readByTableNumberAndPassword_Result> sp_table_readByTableNumberAndPassword(Nullable<int> table_number, string table_password)
        {
            var table_numberParameter = table_number.HasValue ?
                new ObjectParameter("table_number", table_number) :
                new ObjectParameter("table_number", typeof(int));
    
            var table_passwordParameter = table_password != null ?
                new ObjectParameter("table_password", table_password) :
                new ObjectParameter("table_password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_table_readByTableNumberAndPassword_Result>("sp_table_readByTableNumberAndPassword", table_numberParameter, table_passwordParameter);
        }
    
        public virtual ObjectResult<sp_category_category_language_readAllByLangguageID_Result> sp_category_category_language_readAllByLangguageID(Nullable<int> language_id)
        {
            var language_idParameter = language_id.HasValue ?
                new ObjectParameter("language_id", language_id) :
                new ObjectParameter("language_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_category_category_language_readAllByLangguageID_Result>("sp_category_category_language_readAllByLangguageID", language_idParameter);
        }
    
        public virtual ObjectResult<sp_category_category_language_readByID_Result> sp_category_category_language_readByID(Nullable<int> category_id)
        {
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_category_category_language_readByID_Result>("sp_category_category_language_readByID", category_idParameter);
        }
    
        public virtual ObjectResult<sp_category_category_language_readAll_Result> sp_category_category_language_readAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_category_category_language_readAll_Result>("sp_category_category_language_readAll");
        }
    
        public virtual ObjectResult<sp_category_category_language_readByCategoryID_Result> sp_category_category_language_readByCategoryID(Nullable<int> category_id)
        {
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_category_category_language_readByCategoryID_Result>("sp_category_category_language_readByCategoryID", category_idParameter);
        }
    
        public virtual ObjectResult<sp_category_category_language_readByCategoryIDAndLanguageID_Result> sp_category_category_language_readByCategoryIDAndLanguageID(Nullable<int> category_id, Nullable<int> language_id)
        {
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            var language_idParameter = language_id.HasValue ?
                new ObjectParameter("language_id", language_id) :
                new ObjectParameter("language_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_category_category_language_readByCategoryIDAndLanguageID_Result>("sp_category_category_language_readByCategoryIDAndLanguageID", category_idParameter, language_idParameter);
        }
    
        public virtual ObjectResult<sp_product_readAllActiveByCategoryIDAndLanguageID_Result> sp_product_readAllActiveByCategoryIDAndLanguageID(Nullable<int> category_id, Nullable<int> language_id)
        {
            var category_idParameter = category_id.HasValue ?
                new ObjectParameter("category_id", category_id) :
                new ObjectParameter("category_id", typeof(int));
    
            var language_idParameter = language_id.HasValue ?
                new ObjectParameter("language_id", language_id) :
                new ObjectParameter("language_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_product_readAllActiveByCategoryIDAndLanguageID_Result>("sp_product_readAllActiveByCategoryIDAndLanguageID", category_idParameter, language_idParameter);
        }
    
        public virtual ObjectResult<sp_product_readByProductIDAndLanguageID_Result> sp_product_readByProductIDAndLanguageID(Nullable<int> product_id, Nullable<int> language_id)
        {
            var product_idParameter = product_id.HasValue ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(int));
    
            var language_idParameter = language_id.HasValue ?
                new ObjectParameter("language_id", language_id) :
                new ObjectParameter("language_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_product_readByProductIDAndLanguageID_Result>("sp_product_readByProductIDAndLanguageID", product_idParameter, language_idParameter);
        }
    
        public virtual ObjectResult<sp_cart_insert_Result> sp_cart_insert(Nullable<int> table_id)
        {
            var table_idParameter = table_id.HasValue ?
                new ObjectParameter("table_id", table_id) :
                new ObjectParameter("table_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_cart_insert_Result>("sp_cart_insert", table_idParameter);
        }
    
        public virtual ObjectResult<sp_cart_readByTableIDAndUserID_Result> sp_cart_readByTableIDAndUserID(Nullable<int> table_id, Nullable<int> user_id)
        {
            var table_idParameter = table_id.HasValue ?
                new ObjectParameter("table_id", table_id) :
                new ObjectParameter("table_id", typeof(int));
    
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_cart_readByTableIDAndUserID_Result>("sp_cart_readByTableIDAndUserID", table_idParameter, user_idParameter);
        }
    
        public virtual int sp_cart_product_insert(Nullable<int> cart_id, Nullable<int> product_id, Nullable<int> quantity)
        {
            var cart_idParameter = cart_id.HasValue ?
                new ObjectParameter("cart_id", cart_id) :
                new ObjectParameter("cart_id", typeof(int));
    
            var product_idParameter = product_id.HasValue ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_cart_product_insert", cart_idParameter, product_idParameter, quantityParameter);
        }
    
        public virtual ObjectResult<sp_cart_product_product_readByCartIDAndLanguageID_Result> sp_cart_product_product_readByCartIDAndLanguageID(Nullable<int> cart_id, Nullable<int> language_id)
        {
            var cart_idParameter = cart_id.HasValue ?
                new ObjectParameter("cart_id", cart_id) :
                new ObjectParameter("cart_id", typeof(int));
    
            var language_idParameter = language_id.HasValue ?
                new ObjectParameter("language_id", language_id) :
                new ObjectParameter("language_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_cart_product_product_readByCartIDAndLanguageID_Result>("sp_cart_product_product_readByCartIDAndLanguageID", cart_idParameter, language_idParameter);
        }
    
        public virtual int sp_cart_product_updateByCartIDAndProductID(Nullable<int> cart_id, Nullable<int> product_id, Nullable<int> quantity)
        {
            var cart_idParameter = cart_id.HasValue ?
                new ObjectParameter("cart_id", cart_id) :
                new ObjectParameter("cart_id", typeof(int));
    
            var product_idParameter = product_id.HasValue ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_cart_product_updateByCartIDAndProductID", cart_idParameter, product_idParameter, quantityParameter);
        }
    
        public virtual ObjectResult<sp_cart_readByTableID_Result> sp_cart_readByTableID(Nullable<int> table_id)
        {
            var table_idParameter = table_id.HasValue ?
                new ObjectParameter("table_id", table_id) :
                new ObjectParameter("table_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_cart_readByTableID_Result>("sp_cart_readByTableID", table_idParameter);
        }
    
        public virtual int sp_user_insert(string user_username, string user_password, string user_first_name, string user_last_name, string user_gender, string user_email, string user_phone, string user_verification_code, Nullable<System.DateTime> user_date_of_birth, Nullable<int> country_id)
        {
            var user_usernameParameter = user_username != null ?
                new ObjectParameter("user_username", user_username) :
                new ObjectParameter("user_username", typeof(string));
    
            var user_passwordParameter = user_password != null ?
                new ObjectParameter("user_password", user_password) :
                new ObjectParameter("user_password", typeof(string));
    
            var user_first_nameParameter = user_first_name != null ?
                new ObjectParameter("user_first_name", user_first_name) :
                new ObjectParameter("user_first_name", typeof(string));
    
            var user_last_nameParameter = user_last_name != null ?
                new ObjectParameter("user_last_name", user_last_name) :
                new ObjectParameter("user_last_name", typeof(string));
    
            var user_genderParameter = user_gender != null ?
                new ObjectParameter("user_gender", user_gender) :
                new ObjectParameter("user_gender", typeof(string));
    
            var user_emailParameter = user_email != null ?
                new ObjectParameter("user_email", user_email) :
                new ObjectParameter("user_email", typeof(string));
    
            var user_phoneParameter = user_phone != null ?
                new ObjectParameter("user_phone", user_phone) :
                new ObjectParameter("user_phone", typeof(string));
    
            var user_verification_codeParameter = user_verification_code != null ?
                new ObjectParameter("user_verification_code", user_verification_code) :
                new ObjectParameter("user_verification_code", typeof(string));
    
            var user_date_of_birthParameter = user_date_of_birth.HasValue ?
                new ObjectParameter("user_date_of_birth", user_date_of_birth) :
                new ObjectParameter("user_date_of_birth", typeof(System.DateTime));
    
            var country_idParameter = country_id.HasValue ?
                new ObjectParameter("country_id", country_id) :
                new ObjectParameter("country_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_user_insert", user_usernameParameter, user_passwordParameter, user_first_nameParameter, user_last_nameParameter, user_genderParameter, user_emailParameter, user_phoneParameter, user_verification_codeParameter, user_date_of_birthParameter, country_idParameter);
        }
    
        public virtual ObjectResult<sp_user_readByUsernameAndPassword_Result> sp_user_readByUsernameAndPassword(string user_username, string user_password)
        {
            var user_usernameParameter = user_username != null ?
                new ObjectParameter("user_username", user_username) :
                new ObjectParameter("user_username", typeof(string));
    
            var user_passwordParameter = user_password != null ?
                new ObjectParameter("user_password", user_password) :
                new ObjectParameter("user_password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_user_readByUsernameAndPassword_Result>("sp_user_readByUsernameAndPassword", user_usernameParameter, user_passwordParameter);
        }
    }
}
