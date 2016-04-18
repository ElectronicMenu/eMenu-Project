using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBClasses;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Electronic_Menu
{
    public partial class User : System.Web.UI.Page
    {
        General gs = new General();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                LoadData();
            }
        }
        public void LoadData()
        {
            String query = "select * from [dbo].[user];";

            DataSet ds = new DataSet();
            ds = gs.getdata(query);
            GridViewUser.DataSource = ds;
            GridViewUser.DataBind();
        }

        protected void GridViewUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void GridViewUser_RowCancelEditing(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void GridViewUser_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Insert"))
            {

                GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
                int i = 0;
                //Getting Text box values
                TextBox txtAddUserName = row.FindControl("txtAddUserName") as TextBox;
                TextBox txtAddfirstName = row.FindControl("txtAddfirstName") as TextBox;
                TextBox txtAdduser_last_name = row.FindControl("txtAdduser_last_name") as TextBox;
                TextBox txtAdduser_password = row.FindControl("txtAdduser_password") as TextBox;
                TextBox txtAdduser_gender = row.FindControl("txtAdduser_gender") as TextBox;
                TextBox txtAdduser_email = row.FindControl("txtAdduser_email") as TextBox;
                TextBox txtAdduser_phone = row.FindControl("txtAdduser_phone") as TextBox;
                CheckBox chkAdd_user_email_verified = row.FindControl("chkAdd_user_email_verified") as CheckBox;
                TextBox txtAdduser_registration_date = row.FindControl("txtAdduser_registration_date") as TextBox;            
                TextBox txtAdduser_verification_codee = row.FindControl("txtAdduser_verification_codee") as TextBox;
                TextBox txtAdduser_date_of_birth = row.FindControl("txtAdduser_date_of_birth") as TextBox;
                TextBox txtAdduser_country_id = row.FindControl("txtAdduser_country_id") as TextBox;

                
                DateTime localDate = DateTime.Now;
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Date is  '"+ localDate + "'');", true);

                 bool temp = false;
                if(chkAdd_user_email_verified.Checked)
                {
                    temp = true;
                }
                
                 
                String insertquery = @"INSERT INTO [dbo].[user] ([user_username] , [user_password]
           ,[user_first_name]
           ,[user_last_name]
           ,[user_gender]
           ,[user_email]
           ,[user_phone]
           ,[user_email_verified]
           ,[user_registration_date]
           ,[user_verification_code]
           ,[user_date_of_birth]
           ,[country_id])
     VALUES
           ( '"" + txtAddUserName.Text.Trim() + ""'
           ,'"" + txtAdduser_password.Text.Trim() + ""'
           ,'"" + txtAddfirstName.Text.Trim() + ""'
           ,'"" + txtAdduser_last_name.Text.Trim() + ""'
           ,'"" + txtAdduser_gender.Text.Trim() + ""'
           ,'"" + txtAdduser_email.Text.Trim() + ""'
           ,'"" + txtAdduser_phone.Text.Trim() + ""'
           ,'"" + chkAdd_user_email_verified.Checked + ""'
           ,'"" + txtAdduser_registration_date.Text.Trim() + ""'
           ,'"" + txtAdduser_verification_codee.Text.Trim() + ""'
           ,'"" + txtAdduser_date_of_birth.Text.Trim() + ""'
           ,'"" + txtAdduser_country_id.Text.Trim() + ""')";

                DataSet ds = new DataSet();
            
                i = gs.changedata(insertquery);
                
      

                /*
                string query = "update category set category_image = '" + txtEditCategoryImage.Text.Trim() + "', category_icon = '" + txtEditCategoryIcon.Text.Trim() + "' where category_id ='"+ cat_id +"' ";
                int i = gs.changedata(sp_category_category_language_insert);
                */
                if (i > 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Record Inserted succesfully');", true);

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Error ocurred while Inserting');", true);
                }

                LoadData();
            }
        }

        protected void GridViewUser_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridViewUser_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridViewUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}