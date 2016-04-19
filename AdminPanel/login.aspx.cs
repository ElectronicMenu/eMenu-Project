using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using DBClasses;
using System.Configuration;

namespace Electronic_Menu
{
    public partial class login : System.Web.UI.Page
    {
        General gs = new General();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {


            String query = "select * from [dbo].[user] where user_username = '" + txtUserName.Text.Trim() + "' and user_password = '" +  txtPassword.Text.Trim() + "';";
            DataSet ds = new DataSet();
            ds = gs.getdata(query);
            string username;
            int uid = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                username = ds.Tables[0].Rows[0]["user_username"].ToString();
                uid = Convert.ToInt32(ds.Tables[0].Rows[0]["user_id"]);
                Session["username"] = txtUserName.Text;
                Session["password"] = txtPassword.Text;
                Session["uid"] = uid;
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Welcome " + txtUserName.Text + "');", true);
                Response.Redirect("Category.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Username or Password Invalid');", true);
            }
        }
    }
}