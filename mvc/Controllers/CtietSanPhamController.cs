using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;
using mvc.Buss;

namespace mvc.Controllers
{
    public class CtietSanPhamController : Controller
    {
        SanPhamBUS pb = new SanPhamBUS();
        // GET: CtietSanPham
        public ActionResult Index()
        {
            return View();
        }
        //public JsonResult GetCTSP(string ProID)
        //{
        //    Sanpham sp = pb.LaySanPhamLoai(ProID);
        //    return Json(sp, JsonRequestBehavior.AllowGet);
        //}
    }
}