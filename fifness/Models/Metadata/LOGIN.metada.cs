using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fifness.Models.Metadata
{
    public class LOGIN
    {
        [Display(Name = "Tên Đăng Nhập")]
        [Required(ErrorMessage = "Yêu cầu nhập tên đăng nhập")]
        public string USERNAME { get; set; }

        [Display(Name = "Mật Khẩu")]
        [Required(ErrorMessage = "Yêu cầu nhập Mật Khẩu ")]
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public string THONGBAO { get; set; }
    }
}