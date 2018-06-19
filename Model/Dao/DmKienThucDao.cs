using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.Dao
{
    public class DmKienThucDao
    {
        Db_CNTT db = null;
        public DmKienThucDao()
        {
            db = new Db_CNTT();
        }

        public List<DanhMucKienThuc> ListAll()
        {
            var danhsach = db.DanhMucKienThucs.Where(a => a.Ten != "").ToList();
            return danhsach;
        }

    }
}
