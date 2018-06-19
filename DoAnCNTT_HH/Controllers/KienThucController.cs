using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnCNTT_HH.Controllers
{
    public class KienThucController : Controller
    {
        // GET: KienThuc
        public ActionResult LearnJava()
        {
            return View();
        }
        public ActionResult LearnCsharp()
        {
           
            return View();
        }
        public ActionResult LearnPython()
        {
            return View();
        }
        public ActionResult DmCsharp()
        {
            var model = new BaiHocDao().ListAllDmcBaiHocCsharp();
            return PartialView(model);

        }
        public ActionResult DmJava()
        {
            var model = new BaiHocDao().ListAllDmcBaiHocJava();
            return PartialView(model);

        }
        public ActionResult DmPython()
        {
            var model = new BaiHocDao().ListAllDmcBaiHocPython();
            return PartialView(model);

        }

        public ActionResult ChiTietBaiHoc(int id)
        {
            var danhmuc = new BaiHocDao().ListAllDanhMucID(id);
            ViewBag.DmBaiHocTheoDmKienThucID = new BaiHocDao().ListAllDanhMucID(danhmuc.DanhMucKienThucID.Value);

            return View(danhmuc);
        }

        public JsonResult ListName(string q)
        {
            var dulieu = new BaiHocDao().ListNameGoiY(q);
            return Json(new
            {
                data = dulieu,
                status = true
            }, JsonRequestBehavior.AllowGet);


        }
        [HttpPost]
        public ActionResult Search(string searching)
        {

            ViewBag.SearchBaiHoc = new BaiHocDao().SearchBaiHoc(searching);
            return View();
        }
    }
}