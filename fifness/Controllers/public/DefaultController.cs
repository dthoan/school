using fifness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using System.Web.Mvc;

namespace fifness.Controllers
{
    public class DefaultController : Controller
    {
        fifnessEntities db = new fifnessEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Element()
        {
            return View();
        }
        public ActionResult Gallegy()
        {
            return View();
        }
        public ActionResult GalleryDetails()
        {
            return View();
        }
        public ActionResult Pages()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult chiTietBaiViet(int id)
        {
            var item = db.BAIVIETs.Where(m => m.MABV == id).FirstOrDefault();
            return View(item);
        }

        public ActionResult Blog(int? page)
        {
            // tạo biến số bài viết trong trang
            int pageSize = 6;
            //tạo biến số trang
            int pageNumber = (page ?? 1);


            return View(db.BAIVIETs.ToList().OrderBy(n => n.NGAYVIET).ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Courses()
        {
            return View();
        }
        public ActionResult CoursesShedule()
        {
            return View();
        } public ActionResult SingleBlog()
        {
            return View();
        }
    }
}