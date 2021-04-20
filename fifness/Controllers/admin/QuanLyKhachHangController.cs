using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fifness.Models;


namespace fifness.Controllers
{
    public class QuanLyKhachHangController : Controller
    {
        fifnessEntities db = new fifnessEntities();
        
        // GET: QuanLyKhachHang
        public ActionResult Index()
        {
            var allLoaiTin = from tt in db.KHACHHANGs select tt;
            return View(allLoaiTin);
        }
        // tạo bài viết mới
        public ActionResult Create()
        {
            //// Lấy toàn bộ thể loại:
            //List<NHANVIEN> NhanVien = db.NHANVIENs.ToList();
            //List<THANHVIEN> thanhVien = db.THANHVIENs.ToList();
            
            //// Tạo SelectList
            //SelectList nv = new SelectList(NhanVien, "MANV", "TENNV");
            //SelectList tv = new SelectList(thanhVien, "MATV", "TENTV");

            //// Set vào ViewBag
            //ViewBag.Nv = nv;
            //ViewBag.Tv = tv;

            return View();
        }
        [HttpPost]
        public ActionResult Create(KHACHHANG maKH)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.KHACHHANGs.Add(maKH);
                    db.SaveChanges();
                    return RedirectToAction("Index","QuanLyKhachHang");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException)
                ModelState.AddModelError("", "Lỗi");
            }
            return View(maKH);

        }
    }
}