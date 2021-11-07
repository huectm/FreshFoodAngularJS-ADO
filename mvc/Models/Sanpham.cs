using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class Sanpham
    {

        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string Maloai { get; set; }
        public string Giacu { get; set; }
        public string Giamoi { get; set; }
        public string Soluong { get; set; }
        public string Anh { get; set; }
        public string Ghichu { get; set; }
        public Sanpham(string masp, string tensp,string maloai,string giacu,string giamoi, string soluong,string anh, string ghichu)
        {
            this.MaSach = masp;
            this.TenSach = tensp;
            this.Maloai = maloai;
            this.Giacu = giacu;
            this.Giamoi = giamoi;
            this.Soluong = soluong;
            this.Anh = anh;
            this.Ghichu = ghichu;
        }

        
    }
}