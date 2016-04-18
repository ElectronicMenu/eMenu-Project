using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace DBClasses
{
    public class General
    {
        public General()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public int changedataProc(string strprocname, SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLDbConnection"].ToString());
            SqlCommand cmd = new SqlCommand(strprocname, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter param1 in param)
            {
                if (param != null)
                {
                    cmd.Parameters.Add(param1);
                }
            }

            int i;
            i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public DataSet getdataProc(string strprocname, SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLDbConnection"].ToString());


            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(strprocname, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter param1 in param)
            {
                if (param != null)
                {
                    cmd.Parameters.Add(param1);
                }
            }

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }

        public DataSet getdata(string strsql)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLDbConnection"].ToString());
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(strsql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public int changedata(string strsql)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLDbConnection"].ToString());
            SqlCommand cmd = new SqlCommand(strsql, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int i;
            i = cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            return i;
        }
    }
}