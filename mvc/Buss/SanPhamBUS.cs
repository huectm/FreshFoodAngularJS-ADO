using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc.Models;
using mvc.DAO;

namespace mvc.Buss
{
    public class SanPhamBUS
    {
        SanphamDAO sp = new SanphamDAO();
        public List<Sanpham> GetSanPhams()
        {
            return sp.GetSanpham();

        }
        public List<Sanpham> LaySanPhamLoai(string maloai)
        {
            return sp.LaySPTheoLoai(maloai);
        }
        public SanphamList GetSanPham(string maloai, int pageIndex, int pagesize, string productname)
        {
            return sp.GetSanpham(pageIndex, pagesize, productname, maloai);
        }
    }
}