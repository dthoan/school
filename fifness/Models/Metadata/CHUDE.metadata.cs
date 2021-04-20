using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
// 2 thư viện thiết kế class metadata
using System.ComponentModel;

namespace fifness.Models
{
    [MetadataTypeAttribute(typeof(CHUDEMetadata))]
    public partial class CHUDE
    {
        internal sealed class CHUDEMetadata  // không cho kế thừa
        {

            public int MACD { get; set; }
            [Display(Name ="Tên Chủ Đề")]
            public string TENCD { get; set; }
            public Nullable<int> MABV { get; set; }
            public Nullable<int> MANV { get; set; }
        }

    }
}