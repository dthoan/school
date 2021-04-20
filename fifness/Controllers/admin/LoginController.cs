 using fifness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using fifness.Models.Admin;
using WebMatrix.WebData;
using System.Data.Entity;



namespace fifness.Controllers
{
    public class LoginController : Controller
    {
        fifnessEntities db = new fifnessEntities();

        public ActionResult login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(LOGIN DangKi)
        {
            db.LOGINs.Add(DangKi);
            db.SaveChanges();
            return View("Index", "Login");
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
                
        }

        //[HttpPost, ValidateAntiForgeryToken]
        //public ActionResult dangNhap(fifness.Models.USER loginModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        bool isAuthenticated = WebSecurity.Login(loginModel.USERNAME, loginModel.PASSWORD, loginModel.TRANGTHAI);

        //        if (isAuthenticated!=false)
        //        {
        //            return RedirectToAction("Index", "QuanLyBaiViet");
        //        }

        //    }

        //    return View();
        //}

        //public ActionResult SignOut()
        //{
        //    WebSecurity.Logout();
        //    return RedirectToAction("Index", "Login");
        //}


        [HttpGet]
        public ActionResult ChangePassword(int ID = 0)
        {
            fifness.Models.USER userModel = new fifness.Models.USER();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult ChangePassword(fifness.Models.USER userModel)
        {
            using (db)
            {
                try
                {
                    db.Entry(userModel).State = EntityState.Modified;
                    db.USERs.Add(userModel);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return View("ChangePassword", new fifness.Models.USER());
                }
                ModelState.Clear();
                ViewBag.ThongBao = "Đăng kí thành công";


            }
            return View("ChangePassword", new fifness.Models.USER());
        }


        public ActionResult Index()
        {
            return View();
        }


        //[HttpPost, ValidateAntiForgeryToken]
        //public ActionResult Login(LoginModel loginModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        bool isAuthenticated = WebSecurity.Login(loginModel.UserName, loginModel.Password, loginModel.RememberMe);

        //        if (isAuthenticated)
        //        {
        //            string returnUrl = Request.QueryString["ReturnUrl"];

        //            if (returnUrl == null)
        //            {
        //                return RedirectToAction("Index", "Dashboard");
        //            }
        //            else
        //            {
        //                return Redirect(Url.Content(returnUrl));
        //            }
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Username or Password are invalid.");
        //        }
        //    }

        //    return View();
        //}

        [HttpPost]
        public ActionResult dangNhap(fifness.Models.Metadata.LOGIN userModel)
        {
            using (fifnessEntities db = new fifnessEntities())
            {
                var user = db.USERs.Where(x => x.USERNAME == userModel.USERNAME && x.PASSWORD == userModel.PASSWORD).FirstOrDefault();
                if (user == null)
                {
                    userModel.THONGBAO = "User hoặc password bị sai!";
                    return View("Index", userModel);
                }
                else
                {
                    Session["ID"] = user.ID;
                    Session["USERNAME"] = user.USERNAME;
                    return RedirectToAction("Index", "QuanLyBaiViet");
                }
            }
        }

        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "User");
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }


    }
}