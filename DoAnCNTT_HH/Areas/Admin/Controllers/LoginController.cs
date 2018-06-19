using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;
using DoAnCNTT_HH.Areas.Admin.Models;
using DoAnCNTT_HH.Common;

namespace DoAnCNTT_HH.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult DangNhap()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var userdao = new UserDao();
                var result = userdao.Login(model.UserName, model.Password);
                if (result)
                {
                    var user = userdao.GetById(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.TaiKhoan;
                    userSession.UserID = user.ID;

                    Session.Add(CommonConstants.USER_SESSION, userSession);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng");
                }

               
            }
            return View("DangNhap");
        }
        
    }
}