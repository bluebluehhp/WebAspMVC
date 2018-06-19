using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
namespace DoAnCNTT_HH.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          
            return View();
        }

       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.Your applicatYour application description page.Your application description page.Your application description page.Your applic";

            return View();
        }
        [ChildActionOnly]
        public ActionResult TopMenu()
        {
            var model = new DmKienThucDao().ListAll();
            return PartialView(model);
        }
       
        public ActionResult Next()
        {

            return RedirectToAction("Index", "TinTuc");
        }


    }
}