using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fifness.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace fifness.Controllers
{
    public class QuanLyNhanVienController : Controller
    {
        fifnessEntities db = new fifnessEntities();
        // GET: QuanLyNhanVien
        [HttpGet]
        public ActionResult Index(int ? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 6;
            return View(db.NHANVIENs.ToList().OrderBy(n => n.TENNV).ToPagedList(pageNumber, pageSize));
        }
        
       [HttpGet]
        public ActionResult ThemMoi()
        {
        
            try
            {
                // đưa dữ liệu vào dropdowlist

                ViewBag.MACV = new SelectList(db.CHUCVUs.ToList(), "MACV", "TENCV");
                ViewBag.MAKH = new SelectList(db.KHACHHANGs.ToList(), "MAKH", "TENKH");
                return View();
            }
            catch(Exception ex)
            {
                return View();
            }
        }
        
        [HttpPost]
        public ActionResult ThemMoi(NHANVIEN bv)
        {
            var CurrentCurlture = Session["CurrentCurlture"];
            bv.LANGUEGE = CurrentCurlture.ToString();
            try
            {
                db.NHANVIENs.Add(bv); // thêm dữ liệu vào database
                db.SaveChanges(); // lưu dữ liệu
                return RedirectToAction("Index", "QuanLyNhanVien"); // trả về controller QuanLyBaiViet
            }
            catch (Exception ex)
            {
                return View();
            }

        }

        // Xem toàn bộ bài viết
        public ActionResult Index()
        {
            var allNhanVien = from tt in db.NHANVIENs select tt;
            return View(allNhanVien);
        }
        // hiển thị delete
        public ActionResult Delete(int id)
        {
            var a = db.NHANVIENs.Where(x => x.MANV == id).FirstOrDefault(); // show dữ liệu với id được chọn
            return View(a);
        }
        [HttpPost]
        // xóa bài viết
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                NHANVIEN bv = db.NHANVIENs.Where(x => x.MANV == id).FirstOrDefault(); // show dữ liệu với id được chọn
                db.NHANVIENs.Remove(bv); // xóa dữ liệu
                db.SaveChanges();// lưu dữ liệu sau khi xóa
                return RedirectToAction("Index", "QuanLyNhanVien"); // trả về controller QuanLyBaiViet
            }
            catch
            {
                return View();
            }
        }


     

    }
}