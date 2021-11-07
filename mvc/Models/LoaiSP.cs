using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class LoaiSP
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public LoaiSP() { }
        public LoaiSP(string maloai, string tenloai)
        {
            this.MaLoai = maloai;
            this.TenLoai = tenloai;

        }
    }
}
    