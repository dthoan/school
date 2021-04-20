using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fifness.Models
{
    public class ResetPasswordModel
    {
        [Display(Name = "Mật Khẩu")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Độ dài mật khẩu ít nhất 6 kí tự")]
        [Required(ErrorMessage = "Yêu cầu nhập Mật Khẩu ")]
        public string PASSWORDm { get; set; }

        [Display(Name = "Xác Nhận Mật Khẩu")]
        [Compare("PASSWORD", ErrorMessage = "Xác Nhận Mật Khẩu Không Đúng")]
        public string NHAPLAIPASSWORDm { get; set; }

        [Required]
        public string ResetCode { get; set; }
    }
}