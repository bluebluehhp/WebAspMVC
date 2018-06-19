using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class DanhMucTinTucDao
    {
        Db_CNTT db = null;

        public DanhMucTinTucDao()
        {
            db = new Db_CNTT();
        }


        public List<DanhMucTinTuc> ListDanhMuc()
        {
            var dm = from danhmucc in db.DanhMucTinTucs
                     where danhmucc.Ten != null
                     select danhmucc;

            return dm.ToList();
        }
    }
}
