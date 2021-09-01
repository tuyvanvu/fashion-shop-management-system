using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.EF;
using ShopThoiTrang.Models;

namespace ShopThoiTrang.Controllers
{
    public class CartController : Controller
    {

        string CartSession = "GioHangSessionString";
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CartAll()
        {
            var dao = new CartDAO();
            if (Common.UserLogon.TenDN == "")
                return Redirect("/Dang-Nhap");
            var model = dao.ListAllCart(Common.UserLogon.TenDN);
            ViewBag.SumQuantity = SumQuantity();
            ViewBag.SumAmount = SumAmount();
            return View(model);
        }
        public List<GIOHANG> getCart()
        {
            List<GIOHANG> lstGioHang = Session["GioHang"] as List<GIOHANG>;
            if(lstGioHang == null)
            {
                var dao = new CartDAO();
                lstGioHang = dao.ListAllCart(Common.UserLogon.TenDN);
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }
        public List<Giohang> GetCart()
        {
            CartDAO cartdao = new CartDAO();
            List<Giohang> lstCart = Session[CartSession] as List<Giohang>;
            if (lstCart == null)
            {
                lstCart = new List<Giohang>();
                foreach(GIOHANG gh in cartdao.ListAllCart(Common.UserLogon.TenDN))
                {
                    Giohang gh2 = new Giohang();
                    gh2.NguoiDung = new UserDAO().GetUser(Common.UserLogon.TenDN);
                    gh2.SanPham = new ProductDAO().GetProduct(gh.MASP);
                    gh2.SoLuong = gh.SOLUONGSP.Value;
                    gh2.ThanhToan = false;
                    lstCart.Add(gh2);
                }
                Session[CartSession] = lstCart;
            }
            return lstCart;
        }
        public ActionResult AddItem(string MaSP, int SL)
        {
            var dao = new CartDAO();
            var SP = new ProductDAO().SanPhamDetail(MaSP);
            var cart = dao.ListAllCart(Common.UserLogon.TenDN);
            if (cart.Count != 0)
            {
                if(cart.Exists(x => x.MASP == MaSP))
                {
                    foreach(var item in cart)
                    {
                        if(item.MASP == MaSP)
                        {
                            item.SOLUONGSP += SL;
                        }
                    }
                    dao.SaveChange();
                }
                else
                {
                    var gh = new GIOHANG();
                    gh.MASP = MaSP;
                    gh.SOLUONGSP = SL;
                    gh.TENDN = Common.UserLogon.TenDN;
                    dao.AddCart(gh);
                }
            }
            else
            {
                if (Common.UserLogon.TenDN == "")
                    return Redirect("/Dang-Nhap");
                var gh = new GIOHANG();
                gh.MASP = MaSP;
                gh.SOLUONGSP = SL;
                gh.TENDN = Common.UserLogon.TenDN;
                dao.AddCart(gh);
            }
            return RedirectToAction("CartAll");

        }
        private int SumQuantity()
        {
            int sqtt = 0;
            var dao = new CartDAO();
            List<GIOHANG> lstCart = dao.ListAllCart(Common.UserLogon.TenDN);
            if (lstCart != null)
            {
                sqtt = lstCart.Sum(s => s.SOLUONGSP.Value);
            }
            return sqtt;

        }
        private int SumAmount()
        {
            int sqtt = 0;
            var dao = new CartDAO();
            List<GIOHANG> lstCart = dao.ListAllCart(Common.UserLogon.TenDN);
            if (lstCart != null)
            {
                sqtt = lstCart.Sum(s => (s.SOLUONGSP.Value * (int)s.SANPHAM.GIATRI));
            }
            return sqtt;

        }
        public ActionResult UpdateCart(string MaSP, FormCollection f)
        {
            var dao = new CartDAO();
            List<GIOHANG> lstGioHang = dao.ListAllCart(Common.UserLogon.TenDN);
            GIOHANG gh = lstGioHang.SingleOrDefault(x => x.MASP == MaSP);
            if(gh != null)
            {
                gh.SOLUONGSP = int.Parse(f["txtSoLuongSP"].ToString());
                dao.SaveChange();
            }
            return Redirect("/gio-hang");
        }
        public ActionResult DeleteCart(string MaSP)
        {
            var dao = new CartDAO();
            foreach(GIOHANG gh in dao.ListAllCart(Common.UserLogon.TenDN).ToList())
            {
                if (gh.MASP == MaSP)
                {
                    bool kq = dao.RemoveGioHang(gh.MAGH);
                }
            }
            return Redirect("/gio-hang");
        }
        [HttpGet]
        public ActionResult PayMent()
        {
            CartDAO dao = new CartDAO();
            var session = (Common.UserLogon.TenDN);
            if(session != null)
            {
                var user = new UserDAO().GetUser(session);
                ViewBag.NguoiDung = user;

                List<Giohang> lstCart = GetCart();
                ViewBag.SumQuantity = SumQuantity();
                ViewBag.SumAmount = SumAmount();

                return View(lstCart);
            }
            else
            {
                return Redirect("/Dang-Nhap");
            }
        }
        [HttpPost]
        public ActionResult PayMent(string TenNguoiNhan, string SDT, string DiaChiGiaoHang, string email)
        {
            var session = new UserDAO().GetUser(Common.UserLogon.TenDN);
            var order = new DATHANG();
            order.TENDN = session.TENDN;
            order.NGAYTAO = DateTime.Now.Date;
            order.DIACHIGIAOHANG = DiaChiGiaoHang;
            order.TENNGUOINHAN = TenNguoiNhan;
            order.SDTNHAN = SDT;
            order.EMAIL = email;
            order.THANHTIEN = SumAmount();
            order.THANHTOAN = false;
            try
            {
                string MaDatHang = new OrderDAO().Insert(order);
                var cart = new CartDAO().ListAllCart(Common.UserLogon.TenDN);
                var detailDAO = new DetailOrderDAO();
                foreach (var item in cart)
                {
                    var DetailOrder = new CHITIETDATHANG();
                    DetailOrder.MADATHANG = MaDatHang;
                    DetailOrder.MASANPHAM = item.MASP;
                    DetailOrder.SOLUONG = item.SOLUONGSP;
                    DetailOrder.DONGIA = item.SANPHAM.GIATRI;
                    detailDAO.Insert(DetailOrder);
                }
            }
            catch
            {
                return Redirect("/Thanh-Toan-Loi");
            }
            return Redirect("/Thanh-Toan-Thanh-Cong");
        }
        public ActionResult PayMentSuccess()
        {
            return View();
        }



    }
}