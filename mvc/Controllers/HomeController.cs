using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Buss;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.MaLoai = "";
            return View();
        }
     
        public PartialViewResult GetMenu()
        {
            return PartialView("Menu");
        }
        [HttpGet]
        public JsonResult GetProducts(string maloai)
        {
            SanPhamBUS pb = new SanPhamBUS();
            List<Sanpham> lsp = pb.LaySanPhamLoai(maloai);
            return Json(lsp, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetCategories()
        {
            CategoryBus bl = new CategoryBus();
            List<LoaiSP> l = bl.GetCategory();
            return Json(l, JsonRequestBehavior.AllowGet);
        }
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}
        //public PartialViewResult GetMenu()
        //{
        //    var language = 0;
        //    if (language == 1)
        //        return PartialView("_Menu");
        //    else
        //        return PartialView("_MenuView");
        //}
        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}