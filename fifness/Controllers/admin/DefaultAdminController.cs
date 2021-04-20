using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace fifness.Controllers
{
    public class DefaultAdminController : Controller
    {
       
        // GET: DefaultAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}