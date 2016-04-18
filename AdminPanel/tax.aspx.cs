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
    public partial class tax : System.Web.UI.Page
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
            String query = "select * from [dbo].[tax];";

            DataSet ds = new DataSet();
            ds = gs.getdata(query);
            GridViewTax.DataSource = ds;
            GridViewTax.DataBind();
        }

        protected void GridViewTax_RowCancelEditing(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewTax.EditIndex = -1;
            LoadData();
        }

        protected void GridViewTax_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Insert"))
            {

                GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
                int i = 0;
                //Getting Text box values
                TextBox txtAddtax_percentage = row.FindControl("txtAddtax_percentage") as TextBox;
                

                String insertquery = @"INSERT INTO [dbo].[tax]
           (tax_percentage)
     VALUES
           ('"" + txtAddtax_percentage.Text.Trim() + ""')";

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

        protected void GridViewTax_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var tax_id = GridViewTax.DataKeys[e.RowIndex].Value; // Getting the primary key value from gridview

            string query = "DELETE FROM tax where tax_id ='" + tax_id + "' ";

            int i = gs.changedata(query);
            

            if (i > 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Record Deleted succesfully');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Error ocurred while Deleting');", true);
            }

            LoadData();
        }

        protected void GridViewTax_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewTax.EditIndex = e.NewEditIndex;
            LoadData();
        }

        protected void GridViewTax_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var tax_id = GridViewTax.DataKeys[e.RowIndex].Value; // Getting the primary key value from gridview

            GridViewRow row = GridViewTax.Rows[e.RowIndex] as GridViewRow;

            //Getting Text box values
            TextBox txtEdittax_percentage = row.FindControl("txtEdittax_percentage") as TextBox;

            string query1 = "update tax set tax_percentage = '" + txtEdittax_percentage.Text.Trim() + "' where tax_id ='" + tax_id + "' ";
            
            int i = gs.changedata(query1);
           
            if (i == 1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Record Updated succesfully');", true);
                GridViewTax.EditIndex = -1;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Error ocurred while updating');", true);
            }

            LoadData();
        }

        protected void GridViewTax_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
    }
}