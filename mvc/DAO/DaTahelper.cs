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
    {//lỗi ở đâu?

        string stcon;
        SqlConnection con;
        public Datahelper()
        {
            stcon = ConfigurationManager.ConnectionStrings["string_connection"].ConnectionString;
            con = new SqlConnection(stcon);
        }

        public DataTable GetDataTable(string sql)
        {
        //    if (con.State == ConnectionState.Closed)
        //        con.Open();
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
        public SqlDataReader StoreReaders(string tenStore, params object[] giatri)
        {
            SqlCommand cm;
            con.Open();
            try
            {
                cm = new SqlCommand(tenStore, con);
                cm.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(cm);
                for (int i = 1; i < cm.Parameters.Count; i++)
                {
                    cm.Parameters[i].Value = giatri[i - 1];
                }
                SqlDataReader dr = cm.ExecuteReader();
                return dr;
            }
            catch
            { return null; }
        }

    }
}