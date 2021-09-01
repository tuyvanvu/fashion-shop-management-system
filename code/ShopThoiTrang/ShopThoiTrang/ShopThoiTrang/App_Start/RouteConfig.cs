using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopThoiTrang
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "not finish2",
                url: "tin-tuc",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ShopThoiTrang.Controllers" }
                );
            routes.MapRoute(
                name: "Product All",
                url: "san-pham",
                defaults: new { controller = "Product", action = "ProductAll", id = UrlParameter.Optional },
                namespaces: new[] { "ShopThoiTrang.Controllers" }
                );
            routes.MapRoute(
                name: "Product Detail",
                url: "chi-tiet/{id}",
                defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "QLShopThoiTrang.Controllers" }
            );
            routes.MapRoute(
                name: "Add Cart",
                url: "them-gio-hang/{MaSP}&{SL}",
                defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
                namespaces: new[] { "QLShopThoiTrang.Controllers" }
            );
            routes.MapRoute(
                name: "Not finish",
                url: "Lien-he",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "QLShopThoiTrang.Controllers" }
            );
            routes.MapRoute(
                name: "Not finish3",
                url: "Gioi-thieu",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "QLShopThoiTrang.Controllers" }
            );
            routes.MapRoute(
                name: "Product Category",
                url: "san-pham/{Cateid}",
                defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional },
                namespaces: new[] { "QLShopThoiTrang.Controllers" }
            );
            //them-gio-hang
            routes.MapRoute(
                name: "Item Adding",
                url: "them-gio-hang",
                defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
                namespaces: new[] { "ShopThoiTrang.Controllers" }
                );
            routes.MapRoute(
                name: "Introduce",
                url: "gioi-thieu",
                defaults: new { controller = "About", action = "Introduce", id = UrlParameter.Optional },
                namespaces: new[] { "ShopThoiTrang.Controllers" }
                );
            routes.MapRoute(
                name: "Cart",
                url: "gio-hang",
                defaults: new { controller = "Cart", action = "CartAll", id = UrlParameter.Optional },
                namespaces: new[] { "ShopThoiTrang.Controllers" }
                );
            routes.MapRoute(
                name: "Login",
                url: "dang-nhap",
                defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional },
                namespaces: new[] { "ShopThoiTrang.Controllers" }
                );
            routes.MapRoute(
                name: "Register",
                url: "dang-ky",
                defaults: new { controller = "User", action = "Register", id = UrlParameter.Optional },
                namespaces: new[] { "ShopThoiTrang.Controllers" }
                );
            routes.MapRoute(
                name: "PayMent",
                url: "Thanh-Toan",
                defaults: new { controller = "Cart", action = "PayMent", id = UrlParameter.Optional },
                namespaces: new[] { "ShopThoiTrang.Controllers" }
                );
            routes.MapRoute(
                name: "PayMentSuccess",
                url: "Thanh-Toan-Thanh-Cong",
                defaults: new { controller = "Cart", action = "PayMentSuccess", id = UrlParameter.Optional },
                namespaces: new[] { "ShopThoiTrang.Controllers" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
