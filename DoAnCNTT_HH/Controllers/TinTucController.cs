using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAnCNTT_HH.Common;
using Model.Dao;
using Model.EF;

namespace DoAnCNTT_HH.Controllers
{
    public class TinTucController : Controller
    {
        // GET: TinTuc
        public ActionResult Index()
        {
            ViewBag.VideoMoi = new TinTucDao().VideoMoi();
            ViewBag.TinMoiNhat = new TinTucDao().TinMoiNhat();
            ViewBag.TinXemNhieuNhat = new TinTucDao().TinXemNhieuNhat();
            ViewBag.VideoHot = new TinTucDao().VideoHot();
            ViewBag.DanhMucTinTuc = new DanhMucTinTucDao().ListDanhMuc();
            ViewBag.BaiViet = new TinTucDao().baiviet();
            return View();
        }

        public ActionResult LapTrinh()
        {
            //var model = new DmKienThucDao().ListAll();
            ViewBag.DanhMucTinTuc = new DanhMucTinTucDao().ListDanhMuc();
            ViewBag.BaiViet = new TinTucDao().baiviet();
            ViewBag.BaiVietLapTrinh = new TinTucDao().TinLapTrinh();
            return View();
        }
        public ActionResult ChiTietTinTuc(int id)
        {
            var dao = new TinTucDao();
            var res = dao.UpdateView(id);

            if (res)
            {
                ViewBag.VideoMoi = new TinTucDao().VideoMoi();
                ViewBag.BaiViet_LienQuan = new TinTucDao().BaiVietLienQuan(dao.GetDanhMucByID(id));
                ViewBag.TinMoiNhat = new TinTucDao().TinMoiNhat();
                ViewBag.TinXemNhieuNhat = new TinTucDao().TinXemNhieuNhat();
                ViewBag.VideoHot = new TinTucDao().VideoHot();


                var chiTietTinTuc = new TinTucDao().XemChiTiet(id);


                ViewBag.TinTucTheoID = new TinTucDao().XemChiTiet(chiTietTinTuc.DanhMucTinTucID.Value);
                ViewBag.DanhMucTinTuc = new DanhMucTinTucDao().ListDanhMuc();
                ViewBag.BaiViet = new TinTucDao().baiviet();
                return View(chiTietTinTuc);
            }
            else
            {
                ViewBag.VideoMoi = new TinTucDao().VideoMoi();
                ViewBag.BaiViet_LienQuan = new TinTucDao().BaiVietLienQuan(dao.GetDanhMucByID(id));
                ViewBag.TinMoiNhat = new TinTucDao().TinMoiNhat();
                ViewBag.TinXemNhieuNhat = new TinTucDao().TinXemNhieuNhat();
                ViewBag.VideoHot = new TinTucDao().VideoHot();

                var chiTietTinTuc = new TinTucDao().XemChiTiet(id);
                ViewBag.TinTucTheoID = new TinTucDao().XemChiTiet(chiTietTinTuc.DanhMucTinTucID.Value);


                ViewBag.DanhMucTinTuc = new DanhMucTinTucDao().ListDanhMuc();
                ViewBag.BaiViet = new TinTucDao().baiviet();
                return View(chiTietTinTuc);
            }

            
           
            
        }


        //public ActionResult Upview(TinTuc tt)
        //{
        //    var daoBaiviet = new TinTucDao();
        //    var res = daoBaiviet.Update(tt);
        //    if (res)
        //    {
        //        return RedirectToAction("ChiTietTinTuc","TinTuc");
        //    }
        //    else
        //    {
        //        return RedirectToAction("ChiTietTinTuc", "TinTuc");
        //    }
               
        //}
        public ActionResult KhoaHoc()
        {
            ViewBag.DanhMucTinTuc = new DanhMucTinTucDao().ListDanhMuc();
            ViewBag.BaiViet = new TinTucDao().baiviet();
            ViewBag.BaiVietKhoaHoc = new TinTucDao().TinKhoaHoc();
            return View();
        }
        public ActionResult UngDung()
        {
            ViewBag.DanhMucTinTuc = new DanhMucTinTucDao().ListDanhMuc();
            ViewBag.BaiViet = new TinTucDao().baiviet();
            ViewBag.BaiVietUngDung = new TinTucDao().TinUngDung();
            return View();
        }
        //public ActionResult PhapLuat()
        //{
        //    ViewBag.DanhMucTinTuc = new DanhMucTinTucDao().ListDanhMuc();
        //    ViewBag.BaiViet = new TinTucDao().baiviet();
        //    ViewBag.BaiVietPhapLuat = new TinTucDao().TinPhapLuat();
        //    return View();
        //}
        public ActionResult AnToanThongTin()
        {
            ViewBag.DanhMucTinTuc = new DanhMucTinTucDao().ListDanhMuc();
            ViewBag.BaiViet = new TinTucDao().baiviet();
            ViewBag.BaiVietAnToanThongTin = new TinTucDao().TinAnToanThongTin();
            return View();
        }
        public ActionResult CongNghe()
        {
            ViewBag.DanhMucTinTuc = new DanhMucTinTucDao().ListDanhMuc();
            ViewBag.BaiViet = new TinTucDao().baiviet();
            ViewBag.BaiVietCongNghe = new TinTucDao().TinCongNghe();
            return View();
        }
        public ActionResult GiaiTri()
        {
            ViewBag.DanhMucTinTuc = new DanhMucTinTucDao().ListDanhMuc();
            ViewBag.BaiViet = new TinTucDao().baiviet();
            ViewBag.BaiVietGiaiTri = new TinTucDao().TinGiaiTri();
            return View();
        }

    }
}