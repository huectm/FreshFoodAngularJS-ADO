using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class SanphamList
    {
        public List<Sanpham> Sanphams { get; set; }
        public string totalCount { get; set; }
    }
}