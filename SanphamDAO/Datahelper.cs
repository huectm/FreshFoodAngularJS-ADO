using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
namespace mvc.DAO
{
    public class Datahelper
    {

        string stcon;
        SqlConnection con;
        public Datahelper()
        {
            stcon = ConfigurationManager.ConnectionStrings["string_connection"].ConnectionString;
            con = new SqlConnection();
        }

        public DataTable GetDataTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, stcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string Open()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public void Close()
        {
            if (con.State != ConnectionState.Closed)
                con.Close();
        }




    }
}