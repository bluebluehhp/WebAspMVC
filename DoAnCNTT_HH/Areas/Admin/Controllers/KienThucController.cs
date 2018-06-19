using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnCNTT_HH.Areas.Admin.Controllers
{
    public class KienThucController : Controller
    {
        // GET: Admin/KienThuc
        public ActionResult Index()
        {
            ViewBag.DanhMucKT = new DmKienThucDao().ListAll();
            return View();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new BaiHocDao().XoaBaiHoc(id);
            return RedirectToAction("ListKienThuc");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            ViewBag.DanhMucKT = new DmKienThucDao().ListAll();

            var list = new BaiHocDao().ListAllDanhMucID(ID);
            return View(list);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(BaiHoc baiviet)
        {
            if (ModelState.IsValid)
            {
                var daoBaiviet = new BaiHocDao();
                int id = daoBaiviet.ThemBaiHoc(baiviet);
                if (id > 0)
                {
                    return RedirectToAction("Index", "KienThuc");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm bài học mới thành công");
                }
            }

            //SetDropdownlist();
            return View("Index");
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(BaiHoc baiviet)
        {
            if (ModelState.IsValid)
            {
                var daoBaiviet = new BaiHocDao();
                var res = daoBaiviet.Update(baiviet);
                if (res)
                {
                    //ViewBag.ListCSharp = new BaiHocDao().ListAllDmcBaiHocCsharp();
                    //ViewBag.ListJava = new BaiHocDao().ListAllDmcBaiHocJava();
                    //ViewBag.ListPython = new BaiHocDao().ListAllDmcBaiHocPython();

                    ViewBag.DanhMucKT = new DmKienThucDao().ListAll();
                    return RedirectToAction("ListKienThuc", "KienThuc");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm bài học mới thành công");
                }
            }
            //ViewBag.ListCSharp = new BaiHocDao().ListAllDmcBaiHocCsharp();
            //ViewBag.ListJava = new BaiHocDao().ListAllDmcBaiHocJava();
            //ViewBag.ListPython = new BaiHocDao().ListAllDmcBaiHocPython();

            ViewBag.DanhMucKT = new DmKienThucDao().ListAll();
            //SetDropdownlist();
            return View("ListKienThuc");
        }

        //public void SetDropdownlist(int ? selectedID=null)
        //{
        //    var dao = new DmKienThucDao();
        //    ViewBag.DanhMucKienThucID = new SelectList(dao.ListAll(), "DanhMucKienThucID", "Ten",selectedID);
        //}
        public object ListKienThuc(int page=1, int pageSize=10)
        {


            ViewBag.ListCSharp = new BaiHocDao().PagedList_AllBaiHocCShrap(page, pageSize);
            ViewBag.ListJava = new BaiHocDao().PagedList_AllBaiHocJava(page, pageSize);
            ViewBag.ListPython = new BaiHocDao().PagedList_AllBaiHocPython(page, pageSize);
            return View();
        }

     
    }
}