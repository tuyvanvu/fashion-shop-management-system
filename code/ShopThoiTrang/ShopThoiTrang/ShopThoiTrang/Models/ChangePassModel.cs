using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopThoiTrang.Models
{
    public class ChangePassModel
    {
        
        [Key]
        public long ID { get; set; }

        [Display(Name = "Mật khẩu hiện tại")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Độ dài ít nhất là 6 ký tự.")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Mật khẩu mới")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Độ dài ít nhất là 6 ký tự.")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu mới")]
        public string NewPassword { get; set; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("NewPassword", ErrorMessage = "Xác nhập mật khẩu không đúng.")]
        public string ConfirmNewPassword { get; set; }
        
        

        [Display(Name = "Nhập mã kiểm tra")]
        [StringLength(50)]
        [Required(ErrorMessage = "Yêu cầu nhập mã kiểm tra")]
        public string PrintCode { get; set; }
    }
}