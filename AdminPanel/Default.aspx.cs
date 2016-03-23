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
                            GridViewCategory.DataSource = dt;
                            GridViewCategory.DataBind();
                        }
                    }
                }
            }
        }


        protected void GridViewCategory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewCategory.EditIndex = e.NewEditIndex;
            LoadData();
            ViewState["uid"] = GridViewCategory.DataKeys[e.NewEditIndex].Value;
            

        }
        protected void GridViewCategory_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Insert"))
            {
                var cat_id = GridViewCategory.DataKeys[e.RowIndex].Value; // Getting the primary key value from gridview

            }
        }

        protected void GridViewCategory_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var cat_id = GridViewCategory.DataKeys[e.RowIndex].Value; // Getting the primary key value from gridview

            string query = "DELETE FROM category where category_id ='" + cat_id + "' ";
            int i = gs.changedata(query);
            if (i == 1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Record Deleted succesfully');", true);            
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Error ocurred while Deleting');", true);
            }

            LoadData();

        }

        protected void GridViewCategory_RowCancelEditing(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewCategory.EditIndex = -1;
            LoadData();
        }

        protected void GridViewCategory_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var cat_id = GridViewCategory.DataKeys[e.RowIndex].Value; // Getting the primary key value from gridview

            GridViewRow row = GridViewCategory.Rows[e.RowIndex] as GridViewRow;

            //Getting Text box values
            TextBox txtEditCategoryImage = row.FindControl("txtEditCategoryImage") as TextBox;
            TextBox txtEditCategoryIcon = row.FindControl("txtEditCategoryIcon") as TextBox;
           

            string query = "update category set category_image = '" + txtEditCategoryImage.Text.Trim() + "', category_icon = '" + txtEditCategoryIcon.Text.Trim() + "' where category_id ='"+ cat_id +"' ";
            int i = gs.changedata(query);
            if(i == 1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Record Updated succesfully');", true);
                GridViewCategory.EditIndex = -1;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Error ocurred while updating');", true);
            }

            LoadData();
        }
    }
}