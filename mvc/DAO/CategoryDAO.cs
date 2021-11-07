using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc.Models;
using System.Data;

namespace mvc.DAO
{
    public class CategoryDAO
    {
        Datahelper dh = new Datahelper();
        public List<LoaiSP> GetCategory()
        {
            DataTable dt = dh.GetDataTable("Select*from LoaiSach");
            return ToList(dt);
        }

        public List<LoaiSP> ToList(DataTable dt)
        {
            List<LoaiSP> ll = new List<LoaiSP>();
            foreach (DataRow dr in dt.Rows)
            {
                LoaiSP s = new LoaiSP(dr[0].ToString(), dr[1].ToString()
                   );
                ll.Add(s);

            }
            return ll;
        }
    }
}