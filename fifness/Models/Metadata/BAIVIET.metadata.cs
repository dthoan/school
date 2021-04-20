using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
// 2 thư viện thiết kế class metadata
using System.ComponentModel;
using System.Web.Mvc;

namespace fifness.Models
{
 
    [MetadataTypeAttribute(typeof(BAIVIETMetadata))]
    public partial class BAIVIET : Controller
    {
        internal sealed class BAIVIETMetadata  // không cho kế thừa
        {
            [Display(Name = "MABV", ResourceType = typeof(Resoucre.Resource))]
            public int MABV { get; set; }

            [Display(Name = "TENBV", ResourceType = typeof(Resoucre.Resource))] 
            public string TENBV { get; set; }

            [Display(Name = "NOIDUNG", ResourceType = typeof(Resoucre.Resource))]
          
            public string NOIDUNG { get; set; }

            [Display(Name = "HINH", ResourceType = typeof(Resoucre.Resource))]
            public string HINH { get; set; }

            [Display(Name = "NGAYVIET", ResourceType = typeof(Resoucre.Resource))] 
            [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
            public Nullable<System.DateTime> NGAYVIET { get; set; }

            [Display(Name = "MACD", ResourceType = typeof(Resoucre.Resource))]
            public Nullable<int> MACD { get; set; }


        }

    }
}