using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.Dao
{
    public class UserDao
    {

        Db_CNTT db = null;
        public UserDao()
        {
            db = new Db_CNTT();
        }
        public long Insert(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user.ID;
        }
        public User GetById(string userName)
        {
            return db.Users.SingleOrDefault(x => x.TaiKhoan == userName);
        }
        public bool Login(string userName, string passWord)
        {
            var result = db.Users.Count(x => x.TaiKhoan == userName && x.MatKhau == passWord);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
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
