using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Buss;
using mvc.Models;
using mvc.DAO;
namespace mvc.Controllers
{
    public class SanPhamController : Controller
    {
        SanPhamBUS pb = new SanPhamBUS();
        // GET: SanPham
        public ActionResult Index()
        {
            //List<Sanpham> lp = pb.GetSanPhams();
            // return View(lp);
            return View();
        }
        [HttpGet]
        public JsonResult GetSanPham()
        {
            List<Sanpham> lp = pb.GetSanPhams();
            @ViewBag.SoSanPham = lp.Count;
            return Json(new { sp = lp }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetProducts(string maloai)
        {
            List<Sanpham> lsp = pb.LaySanPhamLoai(maloai);
            return Json(lsp, JsonRequestBehavior.AllowGet);
        }
        //public JsonResult GetSanPhamTL(string maloai, int pageIndex, int pageSize, string productName)
        //{
        //    SanphamList spl = pb.GetSanPham(maloai, pageIndex, pageSize, productName);

        //    return Json(spl, JsonRequestBehavior.AllowGet);
        //}
    }
}