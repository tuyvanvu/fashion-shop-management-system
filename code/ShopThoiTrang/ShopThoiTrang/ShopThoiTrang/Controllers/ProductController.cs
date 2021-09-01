using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.DAO;

namespace ShopThoiTrang.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductAll(int page = 1, int pagesize = 9)
        {
            var dao = new ProductDAO();
            var model = dao.ListAllPageList(page, pagesize);
            return View(model);
        }
        [ChildActionOnly]
        public PartialViewResult ProductCategory()
        {
            var model = new ProductCategoryDAO().ListAll();
            return PartialView(model);
        }
        public ActionResult Category(string CateId, int page = 1, int pageSize = 3)
        {
            var category = new ProductCategoryDAO().ViewDetail(CateId);
            ViewBag.category = category;
            int totalRecord = 0;
            var model = new ProductDAO().ListByCategoryId(CateId, ref totalRecord, page, pageSize);
            ViewBag.Total = totalRecord;
            ViewBag.Page = page;

            int maxPage = 5;
            int totalPage = 0;

            totalPage = (int)Math.Ceiling((double)(totalRecord / pageSize));
            ViewBag.TotalPage = totalPage;
            ViewBag.MaxPage = maxPage;
            ViewBag.First = 1;
            ViewBag.Last = totalPage;
            ViewBag.Next = page + 1;
            ViewBag.Prev = page - 1;

            return View(model);
        }
        public ActionResult Detail(string id)
        {
            var product = new ProductDAO().ViewDetail(id);
            ViewBag.Category = new ProductCategoryDAO().ViewDetail(product.MALOAISP);
            ViewBag.RelateProduct = new ProductDAO().ListRelateProducts(id);
            return View(product);

        }
    }
}