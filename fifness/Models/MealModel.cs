using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace fifness.Models
{
    public class MealModel
    {
        fifnessEntities db = null;
        public MealModel()
        {
            db = new fifnessEntities();
        }
        //public List<THUCDONTHEOTUAN> dsMonAn(int bua)
        //{
        //    //SqlParameter buaan = new SqlParameter("@id_bua_an", bua);
        //    //var item = db.Database.SqlQuery<THUCDONTUAN>("proc_dsMonAn", buaan).ToList();

        //    var param1 = new SqlParameter();
        //    param1.ParameterName = "@id_bua_an";
        //    param1.SqlDbType = SqlDbType.Int;
        //    param1.SqlValue = bua;
        //    var item = db.Database.SqlQuery<THUCDONTHEOTUAN>("proc_dsMonAn @id_bua_an", param1).ToList();

        //    //var item = db.Database.SqlQuery("proc_dsMonAn", param1).ToList();
        //    //var item = db.Database.SqlQuery<THUCDONTHEOTUAN>("proc_dsMonAn", param1).ToList();
        //    return item;
        //}

        //public List<THUCDONTHEOTUAN> layMaLop(int id)
        //{
        //    var param1 = new SqlParameter();
        //    param1.ParameterName = "@ma_lop";
        //    param1.SqlDbType = SqlDbType.Int;
        //    param1.SqlValue = id;
        //    var item = db.Database.SqlQuery<THUCDONTHEOTUAN>("proc_layMaLop @ma_lop", param1).ToList();
        //    return item;
        //}

        //public static List<NHANVIEN> getDSNhanVien()
        //{
        //    DbContext dc = new DbContext("name=fifnessEntities");
        //    var nv = dc.Set<NHANVIEN>();
        //    return nv.Take(6).ToList<NHANVIEN>();
        //}

        public List<HOCSINH> getfullPhieuAn()
        {
            DbContext db = new DbContext("name=fifnessEntities");
            var list = db.Set<HOCSINH>().ToList();
            return list;
        }

        public List<THUCDONTHEOTUAN> dsthucDonTuan()
        {
            DbContext db = new DbContext("name=fifnessEntities");
            var list = db.Database.SqlQuery<THUCDONTHEOTUAN>("proc_thucDonTheoTuan").ToList();
            return list;
        }

        public List<THUCDONTHEOTUAN> getMaLop()
        {
            DbContext db = new DbContext("name=fifnessEntities");
            var list = db.Database.SqlQuery<THUCDONTHEOTUAN>("exec proc_laylop").ToList();
            return list;
        }

        public List<THUCDONTHEOTUAN> getNgayTao()
        {
            DbContext db = new DbContext("name=fifnessEntities");
            var list = db.Database.SqlQuery<THUCDONTHEOTUAN>("exec proc_layngaynhap").ToList();
            return list;
        }

    }
}