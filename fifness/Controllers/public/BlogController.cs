using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fifness.Models;
using PagedList;
using PagedList.Mvc;

namespace fifness.Controllers
{
    public class BlogController : Controller
    {
        fifnessEntities db = new fifnessEntities();
        // GET: Blog
        public ActionResult Index(int? page)
            
        {
            // tạo biến số bài viết trong trang
            int pageSize = 6;
            //tạo biến số trang
            int pageNumber = (page ?? 1);


            return View(db.BAIVIETs.ToList().OrderBy(n=>n.NGAYVIET).ToPagedList(pageNumber,pageSize));
        }

      
    }
}