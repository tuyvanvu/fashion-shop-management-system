using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.DAO;


namespace ShopThoiTrang.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string searchString, int page = 1, int pageSize = 12)
        {
            var dao = new ProductDAO();
            var model = dao.ListAllPaging(searchString, page, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }
        public ActionResult TopMenu()
        {
            return PartialView();
        }
        public ActionResult MainMenu()
        {
            return PartialView();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}