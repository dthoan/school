using fifness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fifness.Dao
{
    public class NhanVienDao
    {
        public int MABV { get; set; }
        public string TENBV { get; set; }
        public string NOIDUNG { get; set; }
        public string HINH { get; set; }
        public Nullable<System.DateTime> NGAYVIET { get; set; }
        public Nullable<int> MACD { get; set; }
        public string LANGUEGE { get; set; }

        public virtual CHUDE CHUDE { get; set; }
        public virtual LANGUEGE LANGUEGE1 { get; set; }
    }
}