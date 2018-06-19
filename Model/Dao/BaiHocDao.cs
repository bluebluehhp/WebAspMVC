using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.Dao
{
    public class BaiHocDao
    {
        Db_CNTT db = null;
        public BaiHocDao()
        {
            db = new Db_CNTT();
        }

        public List<BaiHoc> SearchBaiHoc(string searching)
        {
            //if (!string.IsNullOrEmpty(searching))
            //{
               
            //}

            var temp = from ds in db.BaiHocs
                       where ds.TieuDe.Contains(searching)
                       select ds;
            return temp.ToList();

        }

        

        public List<string> ListNameGoiY(string keyword)
        {
            return db.BaiHocs.Where(x =>x.TieuDe.Contains(keyword)).Select(x => x.TieuDe).ToList();
        }

        public IEnumerable<BaiHoc> PagedList_AllBaiHocJava(int page, int pageSize)
        {
            var temp= from ds in db.BaiHocs
                      where ds.DanhMucKienThucID == 3
                      select ds;

            return temp.OrderByDescending(x => x.NgayTao).ToPagedList(page, pageSize);
        }

        public IEnumerable<BaiHoc> PagedList_AllBaiHocCShrap(int page, int pageSize)
        {
            var temp = from ds in db.BaiHocs
                       where ds.DanhMucKienThucID == 2
                       select ds;

            return temp.OrderByDescending(x => x.NgayTao).ToPagedList(page, pageSize);
        }
        public IEnumerable<BaiHoc> PagedList_AllBaiHocPython(int page, int pageSize)
        {
            var temp = from ds in db.BaiHocs
                       where ds.DanhMucKienThucID == 1
                       select ds;

            return temp.OrderByDescending(x => x.NgayTao).ToPagedList(page, pageSize);
        }





        public List<BaiHoc> ListAllDmcBaiHocCsharp()
        {
            var listBaiHoc = from ds in db.BaiHocs
                             where ds.DanhMucKienThucID == 2
                             select ds;

            return listBaiHoc.ToList();

        }
        public BaiHoc ChiTietBaiHoc(int ID)
        {
            return db.BaiHocs.Find(ID);
        }

        public List<BaiHoc> ListAllDmcBaiHocJava()
        {
            var listBaiHoc = from ds in db.BaiHocs
                             where ds.DanhMucKienThucID == 3
                             select ds;

            return listBaiHoc.ToList();
        }

        public List<BaiHoc> ListAllDmcBaiHocPython()
        {
            var listBaiHoc = from ds in db.BaiHocs
                             where ds.DanhMucKienThucID == 1
                             select ds;

            return listBaiHoc.ToList();
        }
        public BaiHoc ListAllDanhMucID(int ID)
        {
            return db.BaiHocs.Find(ID);
        }

        public int ThemBaiHoc(BaiHoc baivietmoi)
        {
            db.BaiHocs.Add(baivietmoi);
            baivietmoi.NgayTao = DateTime.Now;
            baivietmoi.LuotXem = 0;
            db.SaveChanges();
            return baivietmoi.BaiHocID;

        }

        public bool UpdateView(BaiHoc entity)
        {
            try
            {
                entity.LuotXem += 1;
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
        public bool XoaBaiHoc(int id)
        {
            try
            {
                var dao = db.BaiHocs.Find(id);
                db.BaiHocs.Remove(dao);
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
                        
        }
        public bool Update(BaiHoc entity)
        {
            try
            {
                var dao = db.BaiHocs.Find(entity.BaiHocID);
                dao.BaiHocID = entity.BaiHocID;
                dao.DanhMucKienThucID = entity.DanhMucKienThucID;
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
