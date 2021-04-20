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
    [MetadataTypeAttribute(typeof(NHANVIENMetadata))]
    public partial class NHANVIEN : Controller
    {
        internal sealed class NHANVIENMetadata  // không cho kế thừa
        {
            [Display(Name = "MANV", ResourceType = typeof(ResoucreNhanVien.ResourcenNhanVien))]
            [Required(ErrorMessage = "Vui lòng nhập mã Nhân Viên! ")]
            public int MANV { get; set; }

            [Display(Name = "TENNV", ResourceType = typeof(ResoucreNhanVien.ResourcenNhanVien))]
            [Required(ErrorMessage = "Vui lòng nhập mã Nhân Viên! ")]
            public string TENNV { get; set; }

            [Display(Name = "SDT", ResourceType = typeof(ResoucreNhanVien.ResourcenNhanVien))]
            [Required(ErrorMessage = "Số Điện Thoại! ")]
            public string SDT { get; set; }

            [Display(Name = "GIOITINH", ResourceType = typeof(ResoucreNhanVien.ResourcenNhanVien))]
            public string GIOITINH { get; set; }

            [Display(Name = "DIACHI", ResourceType = typeof(ResoucreNhanVien.ResourcenNhanVien))]
            public string DIACHI { get; set; }

            [Display(Name = "HINH", ResourceType = typeof(ResoucreNhanVien.ResourcenNhanVien))]
            public string HINH { get; set; }

            [Display(Name = "MAKH", ResourceType = typeof(ResoucreNhanVien.ResourcenNhanVien))]
            public Nullable<int> MAKH { get; set; }

            [Display(Name = "GIOITHIEU", ResourceType = typeof(ResoucreNhanVien.ResourcenNhanVien))]
            [Required(ErrorMessage = "Vui lòng nhập giới thiệu ")]
            public string GIOITHIEU { get; set; }

            [Display(Name = "HINHmh", ResourceType = typeof(ResoucreNhanVien.ResourcenNhanVien))]
            public Nullable<int> MACV { get; set; }
            public string HINHmh { get; set; }

            public string LANGUEGE { get; set; }
        }
    }
}