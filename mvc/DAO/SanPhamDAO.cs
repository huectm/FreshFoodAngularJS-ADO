using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc.Models;
using System.Data;
using ToPage;
using System.Data.SqlClient;

namespace mvc.DAO
{
    public class SanphamDAO
    {
        Datahelper dh = new Datahelper();
        public List<Sanpham> GetSanpham()
        {
            DataTable dt = dh.GetDataTable("Select*from Sach");
            return ToList(dt);
        }

        public List<Sanpham> ToList(DataTable dt)
        {
            List<Sanpham> l = new List<Sanpham>();
            foreach (DataRow dr in dt.Rows)
            {
                Sanpham s = new Sanpham(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
                    dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                l.Add(s);

            }
            return l;
        }
        public SanphamList GetSanpham(int pageIndex, int pageSize, string productName, string maLoai)
        {
            SanphamList sql = new SanphamList();
            List<Sanpham> l = new List<Sanpham>();
            SqlDataReader dr = dh.StoreReaders("GetSanPhams", pageIndex, pageSize, productName, maLoai);
            while (dr.Read())
            {
                Sanpham s = new Sanpham(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
                    dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                l.Add(s);
            }
            sql.Sanphams = l;
            dr.NextResult();
            while (dr.Read())
            {
                sql.totalCount = dr["totalCount"].ToString();
            }
            return sql;

        }
        public List<Sanpham> LaySPTheoLoai(string maloai)
        {
            DataTable dt = dh.GetDataTable("select * from Sach where Maloai='" + maloai +"'");
            return ToList(dt);
        }
    }
 
}
