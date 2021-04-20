using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fifness.Models; 


namespace fifness.Controllers
{
    public class UserController : Controller
    {
        fifnessEntities db = new fifnessEntities();
        // GET: User
      

        public ActionResult Index()
        {
            var allLoaiTin = from tt in db.USERs select tt;
            return View(allLoaiTin);
        }

        [HttpGet]
        public ActionResult Create()
        {
            // đưa dữ liệu vào dropdowlist
            ViewBag.MANV = new SelectList(db.NHANVIENs.ToList(), "MANV", "TENNV");
            return View();
        }

        [HttpPost]
        public ActionResult Create(USER user)
        {
            try
            {
                db.USERs.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            // đưa dữ liệu vào dropdowlist
            ViewBag.MANV = new SelectList(db.NHANVIENs.ToList(), "MANV", "TENNV");
            var a = db.USERs.Where(x => x.ID == id).FirstOrDefault(); //  show bài viết với id đã chọn
            return View(a);
        }
        [HttpPost]
        public ActionResult Edit(USER bv)
        {
            try
            {
                db.Entry(bv).State = EntityState.Modified; // edit dữ liệu dc chọn
                db.SaveChanges(); // lưu dữ liệu
                return RedirectToAction("Index", "User"); // trả về controller QuanLyBaiViet với view là Index
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // hiển thị delete
        public ActionResult Delete(int id)
        {
            var a = db.USERs.Where(x => x.ID == id).FirstOrDefault(); // show dữ liệu với id được chọn
            return View(a);
        }
        [HttpPost]
        // xóa bài viết
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                USER bv = db.USERs.Where(x => x.ID == id).FirstOrDefault(); // show dữ liệu với id được chọn
                db.USERs.Remove(bv); // xóa dữ liệu
                db.SaveChanges();// lưu dữ liệu sau khi xóa
                return RedirectToAction("Index", "User"); // trả về controller QuanLyBaiViet
            }
            catch
            {
                return View();
            }
        }
        // chi tiết
        public ActionResult Details(int id)
        {
            var a = db.USERs.Where(x => x.ID == id).FirstOrDefault(); // show dữ liệu với id được chọn
            return View(a);
        }

    }
}