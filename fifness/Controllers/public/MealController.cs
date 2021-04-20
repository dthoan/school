using fifness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fifness.Models;

namespace fifness.Controllers
{
    public class MealController : Controller
    {
        public ActionResult report()
        {
            var item = db.HOCSINHs.ToList();
            return View(item);
        }


        // GET: Meal
        fifnessEntities db = new fifnessEntities();
        public ActionResult Index()
        {
            ViewBag.mon1 = new SelectList(db.MONANs.Where(m=>m.ID_NHOM_THUC_AN==1).ToList(), "NHOM_THUC_AN", "TEN_MON");
            ViewBag.mon2 = new SelectList(db.MONANs.Where(m=>m.ID_NHOM_THUC_AN == 2).ToList(), "NHOM_THUC_AN", "TEN_MON");
            ViewBag.mon3 = new SelectList(db.MONANs.Where(m=>m.ID_NHOM_THUC_AN == 3).ToList(), "NHOM_THUC_AN", "TEN_MON");
            ViewBag.mon4 = new SelectList(db.MONANs.Where(m=>m.ID_NHOM_THUC_AN == 4).ToList(), "NHOM_THUC_AN", "TEN_MON");
            ViewBag.mon5 = new SelectList(db.MONANs.Where(m=>m.ID_NHOM_THUC_AN == 5).ToList(), "NHOM_THUC_AN", "TEN_MON");
         

            return View();
        }
        public ActionResult ChonMonAn()
        {
            ViewBag.mon1 = new SelectList(db.MONANs.Where(m => m.ID_NHOM_THUC_AN == 1).ToList(), "NHOM_THUC_AN", "TEN_MON");
            return View();
        }
        public ActionResult dsGiaoVien()
        {
            var list = db.NHANVIENs.ToList();
            return View(list);
        }
      
        public  ActionResult dsHocSinhTheoGiaoVien(int id)
        {
            var lisths = db.HOCSINHs.Where(m => m.MA_LOP == id).ToList();
            return View(lisths);
        }
        public ActionResult dsHocsinh()
        {
            return View();
        }
        // CHI TIẾT PHIẾU THU
        public ActionResult PhieuThu(int id)
        {
          
            var item = db.HOCSINHs.Where(m => m.MA_HS == id).FirstOrDefault();
            return View(item);
        }

       
       

        public ActionResult dsLop()
        {


            var all = from tt in db.LOPs select tt;
            return View(all);
            
        }

        // xem thữ đơn
        public ActionResult xemthucdonTheoLop(int ma_lop)
        {
            ViewBag.mon = db.THUCDONTHEOTUANs.Where(m => m.MA_LOP == ma_lop).ToList();
            ViewBag.ngay = db.THUCDONTHEOTUANs.Where(m => m.MA_LOP == ma_lop).First();
            ViewBag.bua  = db.THUCDONTHEOTUANs.Where(m => m.MA_LOP == ma_lop).First();
            var thucDonTheoLop = db.THUCDONTHEOTUANs.Where(x => x.MA_LOP == ma_lop).ToList(); //  show bài viết với id đã chọn
            //var thucDonTheoLop = db.THUCDONTHEOTUANs.Where(x => x.MA_LOP == ma_lop).ToList(); //  show bài viết với id đã chọn
            ViewBag.thucdontheolop = thucDonTheoLop;
            return View(thucDonTheoLop);
        }

        public ActionResult ThucDonTheoTuan()
        {

            ViewBag.buasang = new THUCDONTHEOTUAN();
            ViewBag.buatrua = new THUCDONTHEOTUAN();
            ViewBag.buatoi = new THUCDONTHEOTUAN();
            ViewBag.buaphu = new THUCDONTHEOTUAN();


            var buasang = db.THUCDONTHEOTUANs.Where(m => m.ID_BUA_AN == 1).ToList();
                               
            var buatrua = db.THUCDONTHEOTUANs.Where(m => m.ID_BUA_AN == 2).ToList();
            var buatoi = db.THUCDONTHEOTUANs.Where(m => m.ID_BUA_AN == 3).ToList();
            var buaphu = db.THUCDONTHEOTUANs.Where(m => m.ID_BUA_AN == 4).ToList();

            // MÃ LỚP
            var lop1 = db.THUCDONTHEOTUANs.Where(m => m.MA_LOP == 1).First();

            ViewBag.buasang = buasang.Take(5);
            ViewBag.buatrua = buatrua.Take(5);
            ViewBag.buatoi = buatoi.Take(5);
            ViewBag.buaphu = buaphu.Take(5);
            ViewBag.lop1 = lop1;

            ViewBag.all = db.THUCDONTHEOTUANs.First();

            //var list = new MealModel();
          
            //ViewBag.buasang = list.dsMonAn(1);
            //ViewBag.buatrua= list.dsMonAn(2);
            //ViewBag.buatoi = list.dsMonAn(3);
            //ViewBag.buaphu = list.dsMonAn(4);
            return View();
        }

        public ActionResult TimThucDon()
        {
          
            return View();
        }

        // lấy mã lớp
      

       public ActionResult dsThucDonTheoTuan()
        {
           
            var thucdon = db.THUCDONTHEOTUANs.SqlQuery("EXEC proc_thucDonTheoTuan").ToList<THUCDONTHEOTUAN>();
            var buatrua = db.THUCDONTHEOTUANs.SqlQuery("EXEC proc_laybuatrua").ToList<THUCDONTHEOTUAN>();
            var buasang = db.THUCDONTHEOTUANs.SqlQuery("EXEC proc_laybuasang").ToList<THUCDONTHEOTUAN>();
            var buatoi = db.THUCDONTHEOTUANs.SqlQuery("EXEC proc_laybuatoi").ToList<THUCDONTHEOTUAN>();
            var buaphu = db.THUCDONTHEOTUANs.SqlQuery("EXEC proc_laybuaphu").ToList<THUCDONTHEOTUAN>();
            var ngay = db.THUCDONTHEOTUANs.SqlQuery("EXEC proc_layngaynhap").ToList<THUCDONTHEOTUAN>();
            var lop = db.THUCDONTHEOTUANs.SqlQuery("EXEC proc_laylop").ToList<THUCDONTHEOTUAN>();
            ViewBag.sang = buasang;
            ViewBag.trua = buatrua;
            ViewBag.toi = buatoi;
            ViewBag.phu = buaphu;
            ViewBag.ngay = ngay;
            ViewBag.lop = lop;



            //foreach (var item in buasang)
            //{
            //    ViewBag.sang = item.MONAN.TEN_MON;
            //};

            //foreach (var item in buatrua)
            //{
            //    ViewBag.trua = item.MONAN.TEN_MON;
            //};

            //foreach (var item in buatoi)
            //{
            //    ViewBag.toi = item.MONAN.TEN_MON;
            //};
            //foreach (var item in buaphu)
            //{
            //    ViewBag.phu = item.MONAN.TEN_MON;
            //};
            //foreach (var item in lop)
            //{
            //    ViewBag.lop = item.LOP.TEN_LOP;
            //};
            //foreach (var item in ngay)
            //{
            //    ViewBag.ngay = item.NGAYNHAP;
            //};

            foreach (var item in thucdon)
            {
                ViewBag.idthucdon = item.ID_THUC_DON;
                ViewBag.buaan = item.BUAAN.TEN_BUA;
                ViewBag.monan = item.MONAN.TEN_MON;
                ViewBag.lopl = item.LOP.TEN_LOP;
                ViewBag.ngayl = item.NGAYNHAP;

            };
            return View(thucdon);


        }

        //public ActionResult TimThucDonTheoLich(DateTime searchString)
        //{
        //    var allLoaiTin = from tt in db.THUCDONTHEOTUANs select tt;
        //    if (searchString != null)
        //    {
        //        allLoaiTin = db.THUCDONTHEOTUANs.Where(x => x.NGAYNHAP.Contains(searchString));
        //        ViewBag.SearchString = searchString;
        //    }
        //    return View(allLoaiTin);
        //}

        // danh sách phụ huynh
        public ActionResult dsPhuHuynh()
        {
            var phuhuynh = db.KHACHHANGs.ToList();
            return View();
        }

        public ActionResult thucDon()
        {
            ViewBag.buasang = new THUCDONTHEOTUAN();
            ViewBag.buatrua = new THUCDONTHEOTUAN();
            ViewBag.buatoi = new THUCDONTHEOTUAN();
            ViewBag.buaphu = new THUCDONTHEOTUAN();


            var buasang = db.THUCDONTHEOTUANs.Where(m => m.ID_BUA_AN == 1).ToList();

            var buatrua = db.THUCDONTHEOTUANs.Where(m => m.ID_BUA_AN == 2).ToList();
            var buatoi = db.THUCDONTHEOTUANs.Where(m => m.ID_BUA_AN == 3).ToList();
            var buaphu = db.THUCDONTHEOTUANs.Where(m => m.ID_BUA_AN == 4).ToList();

            // MÃ LỚP
            var lop1 = db.THUCDONTHEOTUANs.Where(m => m.MA_LOP == 1).First();

            ViewBag.buasang = buasang.Take(5);
            ViewBag.buatrua = buatrua.Take(5);
            ViewBag.buatoi = buatoi.Take(5);
            ViewBag.buaphu = buaphu.Take(5);



            // theo tuần lọc theo thời gian
          
            ViewBag.sangt = buasang.ToList();
            ViewBag.truat = buatrua.ToList();
            ViewBag.toit = buatoi.ToList();
            ViewBag.phut = buaphu.ToList();

           
         



            return View();
            
        }
        

    }
}