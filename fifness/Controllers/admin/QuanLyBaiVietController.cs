using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fifness.Models;
using OnlineShop.Controllers;
using PagedList;
using PagedList.Mvc;
using fifness.Dao;

namespace fifness.Controllers
{
    public class QuanLyBaiVietController : BaseController
    {
        fifnessEntities db = new fifnessEntities();
        // Xem toàn bộ bài viết
        public ActionResult Index(string searchString)
        {

            var allLoaiTin = from tt in db.BAIVIETs select tt;
            if (!String.IsNullOrEmpty(searchString))
            {
                allLoaiTin = db.BAIVIETs.Where(x => x.TENBV.Contains(searchString) || x.NOIDUNG.Contains(searchString));
                ViewBag.SearchString = searchString;
            }
            return View(allLoaiTin);

        }

        public ActionResult Delete(int id)
        {
            try
            {
               
                BAIVIET bv = db.BAIVIETs.Where(x => x.MABV == id).FirstOrDefault(); // show dữ liệu với id được chọn
                db.BAIVIETs.Remove(bv); // xóa dữ liệu
                db.SaveChanges();// lưu dữ liệu sau khi xóa
                return RedirectToAction("Index", "QuanLyBaiViet"); // trả về controller QuanLyBaiViet
            }
            catch
            {
                return View();
            }
        }
        // hiện thị chi tiết
        public ActionResult Details(int id)
        {
            var a = db.BAIVIETs.Where(x => x.MABV == id).FirstOrDefault(); // show dữ liệu với id được chọn
            return View(a);
        }
        // tạo bài viết mới
        public ActionResult Create()
        {
            // đưa dữ liệu vào dropdowlist
            ViewBag.MACD = new SelectList(db.CHUDEs.ToList(), "MACD", "TENCD");
            return View();
        }
        [HttpPost]
        public ActionResult Create(BAIVIET bv)
        {
            var CurrentCurlture = Session["CurrentCurlture"];
            bv.LANGUEGE = CurrentCurlture.ToString();
            try
            {
                db.BAIVIETs.Add(bv); // thêm dữ liệu vào database
                db.SaveChanges(); // lưu dữ liệu
                return RedirectToAction("Index", "QuanLyBaiViet"); // trả về controller QuanLyBaiViet
            }
            catch (Exception ex)
            {
                return View();
            }

        }
        //edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            // đưa dữ liệu vào dropdowlist
            ViewBag.MACD = new SelectList(db.CHUDEs.ToList(), "MACD", "TENCD");
            var a = db.BAIVIETs.Where(x => x.MABV == id).FirstOrDefault(); //  show bài viết với id đã chọn
            return View(a);
        }
        [HttpPost]
        public ActionResult Edit(BAIVIET bv)
        {
            try
            {
                db.Entry(bv).State = EntityState.Modified; // edit dữ liệu dc chọn
                db.SaveChanges(); // lưu dữ liệu
                return RedirectToAction("Index", "QuanLyBaiViet"); // trả về controller QuanLyBaiViet với view là Index
            }
            catch (Exception ex)
            {
                return View();
            }
        }

    }
}