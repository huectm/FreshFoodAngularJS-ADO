//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
////using mvc.Models;
//using System.Data;
//using ComputerObject;

//namespace mvc.DAO
//{
//    public class SanphamDAO
//    {
//        Datahelper dh = new Datahelper();
//        public List<Sanpham> GetSanpham()
//        {
//            DataTable dt = dh.GetDataTable("Select*from SanPham");
//            return ToList(dt);
//        }

//        public List<Sanpham> ToList(DataTable dt)
//        {
//            List<Sanpham> l = new List<Sanpham>();
//            foreach (DataRow dr in dt.Rows)
//            {
//                Sanpham s = new Sanpham(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
//                    dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
//                l.Add(s);

//            }
//            return l;
//        }
//    }
 
//}
