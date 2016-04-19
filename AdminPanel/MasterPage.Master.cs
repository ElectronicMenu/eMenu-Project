using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Electronic_Menu
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if(!Page.IsPostBack)
            { 
                if (Session["username"] != null)
                {
                    WelcomeUser.Text = Session["username"].ToString();
                }
                else
                {
                    Response.Redirect("login.aspx");
                }

                if (!Page.IsPostBack)
                {
                    
                }
            }
        }

        protected void LogoutLink_Click(object sender, EventArgs e)
        {
           
        }

        protected void LogoutLink_Click(object sender, ImageClickEventArgs e)
        {
            Session.Clear();
            Session.RemoveAll();
            Response.Redirect("login.aspx");
        }
    }
}