//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fifness.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOCSINH
    {
        public int MA_HS { get; set; }
        public string TENHS { get; set; }
        public Nullable<int> MAKH { get; set; }
        public Nullable<int> MA_LOP { get; set; }
        public string HINHANH { get; set; }
        public string GIOITINH { get; set; }
        public Nullable<int> TIEN_AN { get; set; }
        public Nullable<int> HOC_PHI { get; set; }
        public Nullable<int> HOC_THEM { get; set; }
        public Nullable<int> MANV { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual LOP LOP { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
