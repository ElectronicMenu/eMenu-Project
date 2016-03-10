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

namespace Emenu
{
    public partial class Default : System.Web.UI.Page
    {
        General gs = new General();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                LoadData();
                //tbl1.Visible = false;
            }
        }

        public void LoadData()
        {
            string constr = ConfigurationManager.ConnectionStrings["SQLDbConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT category_id,category_image,category_icon FROM category"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridViewSample.DataSource = dt;
                            GridViewSample.DataBind();
                        }
                    }
                }
            }
        }


        protected void GridViewSample_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewSample.EditIndex = e.NewEditIndex;
            LoadData();
            ViewState["uid"] = GridViewSample.DataKeys[e.NewEditIndex].Value;
            

        }
        protected void GridViewSample_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Insert"))
            {

            }
        }

        protected void GridViewSample_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

          
        }

        protected void GridViewSample_RowCancelEditing(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewSample.EditIndex = -1;
            LoadData();
        }

        protected void GridViewSample_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
    }
}