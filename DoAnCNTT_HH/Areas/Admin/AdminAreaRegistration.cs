using System.Web.Mvc;

namespace DoAnCNTT_HH.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
          name: "admin",
          url: "Admin",
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
          namespaces: new[] { "DoAnCNTT_HH.Areas.Admin.Controllers" });

          //  context.MapRoute(
          //name: "Trang chủ admin",
          //url: "admin-home",
          //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
          //namespaces: new[] { "DoAnCNTT_HH.Areas.Admin.Controllers" });



            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}