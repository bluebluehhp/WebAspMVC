using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DoAnCNTT_HH
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            

            routes.MapRoute(
          name: "Danh muc bai hoc",
          url: "learn/{Tag}-{id}",
          defaults: new { controller = "KienThuc", action = "ChiTietBaiHoc", id = UrlParameter.Optional },
          namespaces: new[] { "DoAnCNTT_HH.Controllers" });


            routes.MapRoute(
          name: "Chi tiet tin tuc",
          url: "tin-tuc/{TieuDeSeo}-{id}",
          defaults: new { controller = "TinTuc", action = "ChiTietTinTuc", id = UrlParameter.Optional },
          namespaces: new[] { "DoAnCNTT_HH.Controllers" });




            routes.MapRoute(
          name: "tim kiem",
          url: "tim-kiem",
          defaults: new { controller = "KienThuc", action = "Search", id = UrlParameter.Optional },
          namespaces: new[] { "DoAnCNTT_HH.Controllers" });

            routes.MapRoute(
          name: "Contact",
          url: "lien-he",
          defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional },
          namespaces: new[] { "DoAnCNTT_HH.Controllers" });

            routes.MapRoute(
         name: "Trang Giải trí",
         url: "tin-giaitri",
         defaults: new { controller = "TinTuc", action = "GiaiTri", id = UrlParameter.Optional },
         namespaces: new[] { "DoAnCNTT_HH.Controllers" });

            routes.MapRoute(
         name: "Trang an toàn thông tin",
         url: "tin-antoanthongtin",
         defaults: new { controller = "TinTuc", action = "AnToanThongTin", id = UrlParameter.Optional },
         namespaces: new[] { "DoAnCNTT_HH.Controllers" });

            routes.MapRoute(
         name: "Trang khoa học",
         url: "tin-khoahoc",
         defaults: new { controller = "TinTuc", action = "KhoaHoc", id = UrlParameter.Optional },
         namespaces: new[] { "DoAnCNTT_HH.Controllers" });

            routes.MapRoute(
         name: "Trang ứng dụng",
         url: "tin-ungdung",
         defaults: new { controller = "TinTuc", action = "UngDung", id = UrlParameter.Optional },
         namespaces: new[] { "DoAnCNTT_HH.Controllers" });

            routes.MapRoute(
         name: "Trang lập trình",
         url: "tin-laptrinh",
         defaults: new { controller = "TinTuc", action = "LapTrinh", id = UrlParameter.Optional },
         namespaces: new[] { "DoAnCNTT_HH.Controllers" });

            routes.MapRoute(
         name: "Trang công nghệ",
         url: "tin-congnghe",
         defaults: new { controller = "TinTuc", action = "CongNghe", id = UrlParameter.Optional },
         namespaces: new[] { "DoAnCNTT_HH.Controllers" });

            routes.MapRoute(
          name: "TinTuc",
          url: "tin-tuc",
          defaults: new { controller = "TinTuc", action = "Index", id = UrlParameter.Optional },
          namespaces: new[] { "DoAnCNTT_HH.Controllers" });




            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Next", id = UrlParameter.Optional },
                namespaces: new[] { "DoAnCNTT_HH.Controllers" }
            );
        }
    }
}
