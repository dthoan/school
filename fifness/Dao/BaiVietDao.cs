using fifness.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fifness.Dao
{
    public class BaiVietDao
    {
        fifnessEntities db = null;
        public BaiVietDao()
        {
            db = new fifnessEntities();
        }

        public IEnumerable<BAIVIET> ListAllPage(string searchString, int page, int pageSize = 10)
        {
            IQueryable model = db.BAIVIETs;
            if (!String.IsNullOrEmpty(searchString))
            {
                model = db.BAIVIETs.Where(x => x.TENBV.Contains(searchString) || x.NOIDUNG.Contains(searchString));
            }
            return db.BAIVIETs.OrderByDescending(x => x.NGAYVIET).ToPagedList(page, pageSize);
        }
    }
}