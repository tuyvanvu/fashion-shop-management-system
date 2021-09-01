using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopThoiTrang.Models;
using Model.DAO;
using ShopThoiTrang.Common;

namespace ShopThoiTrang.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                int loginResult = dao.Register(model.UserName, model.Password);
                if (loginResult == -2)
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if (loginResult == -1)
                {
                    ModelState.AddModelError("", "Đăng ký thất bại");
                }
                else
                {
                    if (loginResult == 0)
                    {
                        ViewBag.Success = "Đăng ký thành công";
                        return Redirect("/Dang-Nhap");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký không thành công");
                    }
                }
            }
            return View(model);
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                var loginResult = dao.Login(model.UserName, model.Password);
                if(loginResult == 1)
                {
                    var UserLogin = new UserLogin();
                    UserLogin.UserName = model.UserName;
                    UserLogon.TenDN = model.UserName;
                    ViewBag.Success = "Đăng nhập thành công";
                    return Redirect("/");
                }
                else if(loginResult == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else if (loginResult == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đang bị khóa.");
                }
                else if (loginResult == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng.");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng.");
                }
            }
            return View("Login");
        }
        public ActionResult UserInfo()
        {
            if (Common.UserLogon.TenDN == "")
                return Redirect("/");
            var nd = new UserDAO().GetUser(Common.UserLogon.TenDN);
            return View(nd);
        }
        [HttpGet]
        public ActionResult ChangePassword()
        {
            ChangePassModel model = new ChangePassModel();
            return View(model);
        }
        public ActionResult Logout()
        {
            Common.UserLogon.TenDN = string.Empty;
            return Redirect("/");
        }

        [HttpPost]
        public ActionResult ChangePassword(ChangePassModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new UserDAO().GetUser(Common.UserLogon.TenDN);
                if(!string.IsNullOrEmpty(model.Password))
                {
                    if(user.MATKHAU != model.Password)
                    {
                        ViewBag.LoiMKCu = "Mật khẩu không chính xác";
                    }
                    else
                    {
                        bool kq = new UserDAO().ChangePassword(user.TENDN, model.NewPassword);
                        if(kq)
                            ViewBag.KetQua = "Thay đổi mật khẩu thành công";
                        else
                            ViewBag.KetQua = "Thay đổi mật khẩu thất bại";
                    }
                }
                
            }
            return View();
        }

    }
}