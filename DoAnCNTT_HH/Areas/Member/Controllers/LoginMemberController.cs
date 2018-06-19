using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnCNTT_HH.Areas.Member.Controllers
{
    public class LoginMemberController : Controller
    {
        // GET: Member/LoginMember
        public ActionResult DangNhap()
        {
            return View();
        }
        public ActionResult DangKi()
        {
            return View();
        }
    }
}