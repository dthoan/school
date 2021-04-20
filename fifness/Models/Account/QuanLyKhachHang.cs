using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using fifness.Models;

namespace fifness.Models.Admin
{
    public class QuanLyKhachHang
    {
        fifnessEntities db = new fifnessEntities();
        public IEnumerable<KHACHHANG> layds()
        {
            return db.KHACHHANGs.ToList();
        }
    public KHACHHANG layKH(int maKH)
        {
            return db.KHACHHANGs.First(x => x.MAKH.CompareTo(maKH)==0);
        }
        //public void them(KHACHHANG kh)
        //{
        //    db.KHACHHANGs.Add(kh);
        //    db.SaveChanges(kh);
        //}
        public void sua(KHACHHANG a)
        {
            KHACHHANG b = layKH(a.MAKH);
            b.TENKH = a.TENKH;
            b.NGAYSINH = a.NGAYSINH;
            b.DIACHI = a.DIACHI;
            b.GIOITINH = a.GIOITINH;
            b.MATV = a.MATV;
            b.NHANXET = a.NHANXET;
            b.HINH = b.HINH;
            db.SaveChanges();

        }

        internal void them()
        {
            throw new NotImplementedException();
        }

        public void xoa(int maKH)
        {
            KHACHHANG n = layKH(maKH);
            db.KHACHHANGs.Remove(n);
            db.SaveChanges();

        }

        internal void sua()
        {
            throw new NotImplementedException();
        }
    }
}