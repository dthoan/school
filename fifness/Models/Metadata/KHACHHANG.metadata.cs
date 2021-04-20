using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
// 2 thư viện thiết kế class metadata
using System.ComponentModel;

namespace fifness.Models
{
    [MetadataTypeAttribute(typeof(KHACHHANGMetadata))]
    public partial class KHACHHANG
    {
        
        internal sealed class KHACHHANGMetadata  // không cho kế thừa
        {
            [Display(Name ="Mã Khách Hàng")]
            [Required(ErrorMessage = "Vui lòng nhập mã khách hàng! ")]
            public int MAKH { get; set; }

            [Display(Name ="Tên Khách Hàng")]
            [Required(ErrorMessage = "Vui lòng nhập tên Khách Hàng")]
            public string TENKH { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString ="{0:dd/mm/yyyy}")]
            [Display(Name = "Ngày Sinh")]
            [Required(ErrorMessage = "Vui lòng nhập ngày sinh!")]
            public Nullable<System.DateTime> NGAYSINH { get; set; }

            [Display(Name = "Địa Chỉ")]
            [Required(ErrorMessage = "Vui lòng nhập Địa Chỉ!")]
            public string DIACHI { get; set; }

            [Display(Name = "Giới Tính")]
            [Required(ErrorMessage = "Vui lòng nhập giới tính")]
            public string GIOITINH { get; set; }

            [Display(Name = "Mã Nhân Viên")]
            [Required(ErrorMessage = "Vui lòng nhập Mã Nhân Viên")]
            public Nullable<int> MANV { get; set; }

            [Display(Name = "Mã Thành Viên")]
            [Required(ErrorMessage = "Vui lòng nhập Mã Thành Viên")]
            public Nullable<int> MATV { get; set; }

            [Display(Name = "Nhận Xét")]
            [Required(ErrorMessage = "Vui lòng nhập Nhận Xét")]
            public string NHANXET { get; set; }

            [Display(Name = "Hình Ảnh")]
            [Required(ErrorMessage = "Vui lòng nhập Hình Ảnh")]
            public string HINH { get; set; }


            public Nullable<int> MAKHID { get; set; }

        }
    }
}