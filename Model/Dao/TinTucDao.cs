using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
    public class TinTucDao
    {
        Db_CNTT db = null;
        public TinTucDao()
        {
            db = new Db_CNTT();
        }

        //Timer


        public List<TinTuc> VideoMoi()
        {
            var video = from vd in db.TinTucs
                        where vd.Video != null
                        select vd;

            return video.OrderByDescending(x => x.NgayTao).Take(3).ToList();
        }

        public List<TinTuc> TinMoiNhat()
        {
            return db.TinTucs.OrderByDescending(x => x.NgayTao).Take(3).ToList();
        }

        public List<TinTuc> TinXemNhieuNhat()
        {

            return db.TinTucs.OrderByDescending(x => x.LuotXem).Take(3).ToList();
        }

        public List<TinTuc> VideoHot()
        {
            var video = from vd in db.TinTucs
                        where vd.Video != null
                        select vd;

            return video.OrderByDescending(x => x.LuotXem).Take(1).ToList();
        }
        public bool UpdateView(int id)
        {
            try
            {
                //TinTuc tt = new TinTuc();
                var dao = db.TinTucs.Find(id);
                dao.LuotXem += 1;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool XoaTinTuc(int id)
        {
            try
            {
                var dao = db.TinTucs.Find(id);
                db.TinTucs.Remove(dao);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public int GetDanhMucByID(int id)
        {

            var dao = db.TinTucs.Find(id).DanhMucTinTucID;
            return dao.Value;
        }

        public IEnumerable<TinTuc> ListAllTinTuc(int page, int pageSize)
        {
            return db.TinTucs.OrderByDescending(x => x.NgayTao).ToPagedList(page, pageSize);
        }

        public List<TinTuc> TinLapTrinh()
        {
            var baiVietLapTrinh = from bvLapTrinh in db.TinTucs
                                  where bvLapTrinh.DanhMucTinTucID == 1
                                  select bvLapTrinh;
            return baiVietLapTrinh.OrderByDescending(x => x.NgayTao).ToList();
        }
        public List<TinTuc> TinKhoaHoc()
        {
            var baiVietXahoi = from bvxahoi in db.TinTucs
                               where bvxahoi.DanhMucTinTucID == 8
                               select bvxahoi;
            return baiVietXahoi.OrderByDescending(x => x.NgayTao).ToList();
        }
        public List<TinTuc> TinUngDung()
        {
            var baivietUngDung = from bvUngDung in db.TinTucs
                                 where bvUngDung.DanhMucTinTucID == 3
                                 select bvUngDung;
            return baivietUngDung.OrderByDescending(x => x.NgayTao).ToList();
        }
        //public List<TinTuc> TinPhapLuat()
        //{
        //    var baiviet = from bv in db.TinTucs
        //                        where bv.DanhMucTinTucID == 4
        //                        select bv;
        //    return baiviet.ToList();
        //}
        public List<TinTuc> TinAnToanThongTin()
        {
            var baiviet = from bv in db.TinTucs
                          where bv.DanhMucTinTucID == 5
                          select bv;
            return baiviet.OrderByDescending(x => x.NgayTao).ToList();
        }
        public List<TinTuc> TinCongNghe()
        {
            var baiviet = from bv in db.TinTucs
                          where bv.DanhMucTinTucID == 6
                          select bv;
            return baiviet.OrderByDescending(x => x.NgayTao).ToList();
        }
        public List<TinTuc> TinGiaiTri()
        {
            var baiviet = from bv in db.TinTucs
                          where bv.DanhMucTinTucID == 7
                          select bv;
            return baiviet.OrderByDescending(x => x.NgayTao).ToList();
        }
        public List<TinTuc> baiviet()
        {
            var baiviet = from bv in db.TinTucs
                          where bv.Ten != ""
                          select bv;

            return baiviet.OrderByDescending(x => x.NgayTao).ToList();
        }

        public List<TinTuc> BaiVietLienQuan(int id)
        {
            var baiviet = from bv in db.TinTucs
                          where bv.Ten != "" && bv.DanhMucTinTucID == id
                          select bv;
            return baiviet.OrderByDescending(x => x.NgayTao).Take(6).ToList();
        }


        public TinTuc XemChiTiet(int id)
        {
            return db.TinTucs.Find(id);
        }

        //Thêm mới bài viết

        public int ThemBaiViet(TinTuc baivietmoi)
        {
            db.TinTucs.Add(baivietmoi);
            baivietmoi.NgayTao = DateTime.Now;
            baivietmoi.LuotXem = 0;
            db.SaveChanges();
            return baivietmoi.TinTucID;

        }
        public bool Update(TinTuc entity)
        {
            try
            {
                var dao = db.TinTucs.Find(entity.TinTucID);
                dao.TinTucID = entity.TinTucID;
                dao.DanhMucTinTucID = entity.DanhMucTinTucID;
                dao.TieuDe = entity.TieuDe;
                dao.TieuDeSeo = entity.TieuDeSeo;
                dao.NoiDung = entity.NoiDung;
                dao.NgayTao = DateTime.Now;
                dao.Ten = entity.Ten;

                //if (!string.IsNullOrEmpty())
                //{
                //}
                dao.NguoiTao = entity.NguoiTao;

                dao.Video = entity.Video;
                dao.TrangThai = entity.TrangThai;
                dao.Tag = entity.Tag;
                dao.MoTa = entity.MoTa;
                dao.HinhAnh = entity.HinhAnh;


                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
