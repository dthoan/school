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
    
    public partial class BAIVIET
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