using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace fifness.Models
{
    public class TrungGian
    {
        //Lấy dữ liệu bảng CHUDE
        public static List<CHUDE> getDsChuDe()
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var l = dc.Set<CHUDE>();
            return l.Take(3).ToList<CHUDE>();
        }
        public static List<CHUDE> getFullChuDe()
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var l = dc.Set<CHUDE>();
            return l.ToList<CHUDE>();
            
        }
        // Lấy dữ Liệu bảng khách hàng
        public static List<KHACHHANG> getDSkhachHang()
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var kh = dc.Set<KHACHHANG>();
            return kh.Take(3).ToList<KHACHHANG>();
        }
        //truy vấn từ bảng nhân viên lấy mã nhân viên + tên nhân viên + hình(6)
        public static List<NHANVIEN> getDSNhanVien()
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var nv = dc.Set<NHANVIEN>();
            return nv.Take(6).ToList<NHANVIEN>();
        }
        public static List<NHANVIEN> getDSHinh()
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var nv = dc.Set<NHANVIEN>();
            return nv.Take(1).ToList<NHANVIEN>();
        }
        public static List<KHUYENMAI> getDSKhuyenMai()
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var km = dc.Set<KHUYENMAI>();
            return km.Take(6).ToList<KHUYENMAI>();
        }
        /// Lấy dữ liệu từ bảng bài viết
        public static List<BAIVIET> getDSBaiViet()
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var km = dc.Set<BAIVIET>();
            return km.Take(3).ToList<BAIVIET>();
        }
        public static List<BAIVIET> getDSBaiViet9()
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var km = dc.Set<BAIVIET>();
            return km.Take(9).ToList<BAIVIET>();
        }
        public static List<BAIVIET> getDSNoiDung()
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var km = dc.Set<BAIVIET>();
            return km.Take(1).ToList<BAIVIET>();
        }
        public static List<BAIVIET> getfullNoiDung()
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var km = dc.Set<BAIVIET>();
            return km.ToList<BAIVIET>();
        }
        // lấy danh sách chuyên nghành
        public static List<BAIVIET> baiVietTheoChuDe()
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var bv = dc.Set<BAIVIET>();
            return bv.Take(6).ToList<BAIVIET>();
        }
        // láy bài viết theo chủ đề
        public static List<BAIVIET> getHoaByMaCD(int maCD=0)
        {
            DbContext dc = new DbContext("name=fifnessEntities");
            var l = dc.Set<BAIVIET>().Where(a => a.MACD==maCD).ToList<BAIVIET>();
            return l;
        }

        // PHIẾU ĂN

        public static List<HOCSINH> getfullPhieuAn()
        {
            DbContext db = new DbContext("name=fifnessEntities");
            var list = db.Set<HOCSINH>().ToList<HOCSINH>();
            return list;
        }

        public static HOCSINH PhieuThu(int id)
        {
            DbContext db = new DbContext("name=fifnessEntities");
            var list = db.Set<HOCSINH>().Where(m=>m.MA_HS==id).First<HOCSINH>();
            return list;
        }


        //public List<THUCDONTHEOTUAN> dsthucDonTuan()
        //{
        //    DbContext db = new DbContext("name=fifnessEntities");
        //    var list = db.thu.SqlQuery<THUCDONTHEOTUAN>("proc_thucDonTheoTuan").ToList<THUCDONTHEOTUAN>();
        //    return list;
        //}

        // BÀI VIẾT
        //public static BAIVIET getChiTieBaiViet(int id)
        //{
        //    DbContext db = new DbContext("name=fifnessEntities");
        //    var item = db.Set<BAIVIET>().Where(m => m.MABV == id).First<BAIVIET>;
        //    return item;
        //}

    }
}