using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
// 2 thư viện thiết kế class metadata
using System.ComponentModel;


namespace fifness.Models
{
    [MetadataTypeAttribute(typeof(USERMetadata))]
    public partial class USER
    {
        internal sealed class USERMetadata  // không cho kế thừa
        {
            [Display(Name = "Tên Đăng Nhập")]
            [Required(ErrorMessage = "Nhập tên Đăng Nhập")]
            public string USERNAME { get; set; }

            [Display(Name = "Mật Khẩu")]
            [StringLength(20, MinimumLength = 6, ErrorMessage = "Độ dài mật khẩu ít nhất 6 kí tự")]
            [Required(ErrorMessage = "Yêu cầu nhập Mật Khẩu ")]
            public string PASSWORD { get; set; }

            [Display(Name = "Xác Nhận Mật Khẩu")]
            [DataType(DataType.Password)]
            [Compare("PASSWORD", ErrorMessage = "Xác Nhận Mật Khẩu Không Đúng")]
            public string NHAPLAIPASSWORD { get; set; }

            [Display(Name = "Họ Và Tên")]
            [Required(ErrorMessage = "Yêu cầu nhập Họ và Tên")]
            public string HOTEN { get; set; }

            [Display(Name = "Địa Chỉ")]
            [Required(ErrorMessage = "Yêu cầu nhập Địa Chỉ")]
            public string DIACHI { get; set; }

            [Display(Name = "Email")]
            [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")]
            [Required(ErrorMessage = "Yêu cầu nhập Email")]
            public string EMAIL { get; set; }

            [Display(Name = "Số Điện Thoại")]
            [Required(ErrorMessage = "Yêu cầu nhập Số Điện Thoại")]
            public string SDT { get; set; }

            [Display(Name = "Remember Me:")]
            public bool TRANGTHAI { get; set; }

           
        }
    }
}