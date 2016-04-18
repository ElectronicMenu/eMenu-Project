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
                    DataSet ds = new DataSet();
                    SqlParameter[] sp1 = new SqlParameter[0];
                    ds = gs.getdataProc("hd_emenu.sp_category_category_language_readAll", sp1);
                    GridViewCategory.DataSource = ds;
                    GridViewCategory.DataBind();                      
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

                GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
                int i=0;
                //Getting Text box values
                TextBox txtAddCategoryImage = row.FindControl("txtAddCategoryImage") as TextBox;
                TextBox txtAddCategoryIcon = row.FindControl("txtAddCategoryIcon") as TextBox;
                TextBox txtAddCategoryName = row.FindControl("txtAddCategoryName") as TextBox;
                TextBox txtAddLanguageID = row.FindControl("txtAddLanguageID") as TextBox;

                string query = "select * from category where category_image = '" + txtAddCategoryImage.Text.Trim() + "' and category_icon = '" + txtAddCategoryIcon.Text.Trim() + "';";
                DataSet dataset = new DataSet();
                dataset = gs.getdata(query);

                if(dataset.Tables[0].Rows.Count > 0)
                { 
                    string cate_img = dataset.Tables[0].Rows[0]["category_image"].ToString();
                    string cate_icon = dataset.Tables[0].Rows[0]["category_icon"].ToString();
                    string cate_id = dataset.Tables[0].Rows[0]["category_id"].ToString();
                    string insertquery = "insert into category_language (category_id, language_id, category_name)  VALUES ('" + cate_id + "' , '" +  txtAddLanguageID.Text.Trim() + "', '" + txtAddCategoryName.Text.Trim() + "');";
                    i = gs.changedata(insertquery);
                }
                else
                { 
                    DataSet ds = new DataSet();
                    SqlParameter[] sp1 = new SqlParameter[4];
                    sp1[0] = new SqlParameter("@category_image", txtAddCategoryImage.Text.Trim());
                    sp1[1] = new SqlParameter("@category_icon", txtAddCategoryIcon.Text.Trim());
                    sp1[2] = new SqlParameter("@language_id", txtAddLanguageID.Text.Trim());
                    sp1[3] = new SqlParameter("@category_name", txtAddCategoryName.Text.Trim());

                    i = gs.changedataProc("hd_emenu.sp_category_category_language_insert", sp1);
                }

                /*
                string query = "update category set category_image = '" + txtEditCategoryImage.Text.Trim() + "', category_icon = '" + txtEditCategoryIcon.Text.Trim() + "' where category_id ='"+ cat_id +"' ";
                int i = gs.changedata(sp_category_category_language_insert);
                */
                if (i>0)
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

        protected void GridViewCategory_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var cat_id = GridViewCategory.DataKeys[e.RowIndex].Value; // Getting the primary key value from gridview

            DataSet ds = new DataSet();
            SqlParameter[] sp1 = new SqlParameter[1];
            sp1[0] = new SqlParameter("@category_id", cat_id);
            int i = gs.changedataProc("hd_emenu.sp_category_category_language_deleteByID", sp1);

            /*
            string query = "DELETE FROM category where category_id ='" + cat_id + "' ";
            sp_category_category_language_deleteByID
            int i = gs.changedata(query);
            */

            if (i>0)
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
            TextBox txtEditCategoryName = row.FindControl("txtEditCategoryName") as TextBox;
            TextBox txtEditLanguageID = row.FindControl("txtEditLanguageID") as TextBox;

            /*
            DataSet ds = new DataSet();
            SqlParameter[] sp1 = new SqlParameter[4];
            sp1[0] = new SqlParameter("@category_image", txtEditCategoryImage.Text.Trim());
            sp1[1] = new SqlParameter("@category_icon", txtEditCategoryIcon.Text.Trim());
            sp1[2] = new SqlParameter("@language_id", txtEditLanguageID.Text.Trim());
            sp1[3] = new SqlParameter("@category_name", txtEditCategoryName.Text.Trim());
            

            int i = gs.changedataProc("sp_category_category_language_insert", sp1);
            */
            
            string query1 = "update category set category_image = '" + txtEditCategoryImage.Text.Trim() + "', category_icon = '" + txtEditCategoryIcon.Text.Trim() + "' where category_id ='"+ cat_id +"' ";
            string query2 = "update category_language set category_name = '" + txtEditCategoryName.Text.Trim() + "', language_id = '" + txtEditLanguageID.Text.Trim() + "' where category_id ='" + cat_id + "' ";

            int i = gs.changedata(query1);
            int j = gs.changedata(query2);
            
            if (i == 1 && j ==1)
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

        protected void GridViewCategory_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewCategory.PageIndex = e.NewPageIndex;
            LoadData();
        }
    }
}