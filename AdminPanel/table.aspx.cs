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
    public partial class WebForm1 : System.Web.UI.Page
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
            DataSet ds = new DataSet();
            SqlParameter[] sp1 = new SqlParameter[0];
            ds = gs.getdataProc("dhammi.sp_table_readAll", sp1);
            GridViewTable.DataSource = ds;
            GridViewTable.DataBind();
        }


        protected void GridViewTable_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewTable.EditIndex = e.NewEditIndex;
            LoadData();
            ViewState["uid"] = GridViewTable.DataKeys[e.NewEditIndex].Value;


        }
        protected void GridViewTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Insert"))
            {

                GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
                int i = 0;
                //Getting Text box values
                TextBox txtAddTableNumber = row.FindControl("txtAddTableNumber") as TextBox;
                TextBox txtAddTablePassword = row.FindControl("txtAddTablePassword") as TextBox;
             
                
                
                    DataSet ds = new DataSet();
                    SqlParameter[] sp1 = new SqlParameter[2];
                    sp1[0] = new SqlParameter("@table_number", txtAddTableNumber.Text.Trim());
                    sp1[1] = new SqlParameter("@table_password", txtAddTablePassword.Text.Trim());
                   

                    i = gs.changedataProc("dhammi.sp_table_insert", sp1);
                

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

        protected void GridViewTable_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var cat_id = GridViewTable.DataKeys[e.RowIndex].Value; // Getting the primary key value from gridview
            
            string query = "DELETE FROM table where table_id ='" + cat_id + "' ";
            
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

        protected void GridViewTable_RowCancelEditing(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewTable.EditIndex = -1;
            LoadData();
        }

        protected void GridViewTable_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var table_id = GridViewTable.DataKeys[e.RowIndex].Value; // Getting the primary key value from gridview

            GridViewRow row = GridViewTable.Rows[e.RowIndex] as GridViewRow;

            //Getting Text box values
            TextBox txtEditTableNumber = row.FindControl("txtEditTableNumber") as TextBox;
            TextBox txtEditTablePassword = row.FindControl("txtEditTablePassword") as TextBox;
            TextBox txtEditTableOccupied = row.FindControl("txtEditTableOccupied") as TextBox;
            
            /*
            DataSet ds = new DataSet();
            SqlParameter[] sp1 = new SqlParameter[4];
            sp1[0] = new SqlParameter("@category_image", txtEditCategoryImage.Text.Trim());
            sp1[1] = new SqlParameter("@category_icon", txtEditCategoryIcon.Text.Trim());
            sp1[2] = new SqlParameter("@language_id", txtEditLanguageID.Text.Trim());
            sp1[3] = new SqlParameter("@category_name", txtEditCategoryName.Text.Trim());            
            int i = gs.changedataProc("sp_category_category_language_insert", sp1);
            */

            string query1 = "update [dbo].[table] set table_number = '" + txtEditTableNumber.Text.Trim() + "', table_password = '" + txtEditTablePassword.Text.Trim() + "', table_is_occupied = '" + txtEditTableOccupied.Text.Trim() + "' where table_id ='" + table_id + "' ";

            //string query2 = "update category_language set category_name = '" + txtEditCategoryName.Text.Trim() + "', language_id = '" + txtEditLanguageID.Text.Trim() + "' where category_id ='" + cat_id + "' ";

            int i = gs.changedata(query1);
           // int j = gs.changedata(query2);

            if (i == 1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Record Updated succesfully');", true);
                GridViewTable.EditIndex = -1;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Error ocurred while updating');", true);
            }
            LoadData();
        }

        protected void GridViewTable_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewTable.PageIndex = e.NewPageIndex;
            LoadData();
        }
    }
}