using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnCNTT_HH.Areas.Admin.Controllers
{
    public class TinTucController : BaseController
    {
        // GET: Admin/TinTuc
        public ActionResult Index()
        {
            ViewBag.Listdanhmuc = new DanhMucTinTucDao().ListDanhMuc();
            return View();
        }

        public ActionResult Edit(int id)
        {
            var model = new TinTucDao().XemChiTiet(id);
            ViewBag.Listdanhmuc = new DanhMucTinTucDao().ListDanhMuc();
            return View(model);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new TinTucDao().XoaTinTuc(id);
            return RedirectToAction("ListTinTuc");


        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(TinTuc baiviet)
        {
            if (ModelState.IsValid)
            {

                var daoBaiviet = new TinTucDao();
                int id = daoBaiviet.ThemBaiViet(baiviet);
                if (id > 0)
                {
                    return RedirectToAction("Index", "TinTuc");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm bài viết mới thành công");
                }
            }

            return View("Index");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(TinTuc baiviet)
        {
            if (ModelState.IsValid)
            {

                var daoBaiviet = new TinTucDao();
                var res = daoBaiviet.Update(baiviet);
                if (res)
                {
                    ViewBag.ListBaiViet = new TinTucDao().baiviet();
                    return RedirectToAction("ListTinTuc", "TinTuc");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm bài viết mới thành công");
                }
            }
            ViewBag.ListBaiViet = new TinTucDao().baiviet();
            return View("ListTinTuc");
        }
        public ActionResult ListTinTuc(int page =1, int pageSize=10)
        {
            var dao = new TinTucDao();
            var model = dao.ListAllTinTuc(page, pageSize);
            ViewBag.ListBaiViet = new TinTucDao().baiviet();

            return View(model);
        }

    }
}