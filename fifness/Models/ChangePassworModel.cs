using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fifness.Models
{
    public class ChangePassworModel
    {
        [Display(Name ="Mật khẩu cũ")]
        [Required(ErrorMessage ="Nhập Lại Mật khẩu")]
        [DataType(DataType.Password)]
        public string oldPassword { get; set; }

        [Display(Name = "Mật khẩu cũ")]
        [Required(ErrorMessage = "Nhập Lại Mật khẩu")]
        [DataType(DataType.Password)]
        public string newPassword { get; set; }

        [Display(Name = "Mật khẩu cũ")]
        [Required(ErrorMessage = "Nhập Lại Mật khẩu")]
        [Compare(otherProperty: "newPassword", ErrorMessage ="Mật khẩu không trùng!")]
        [DataType(DataType.Password)]
        public string ConfirmPasswor { get; set; }

    }
}