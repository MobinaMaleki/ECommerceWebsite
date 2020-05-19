using Eshop.Models.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class Settings : EntityBase
    {

        [Display(Name = "توضیح سایت")]
        [MaxLength(150, ErrorMessage = ErrorMsg.MaxLengh)]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string Description { get; set; }

        [MaxLength(75, ErrorMessage = ErrorMsg.MaxLengh)]
        [Display(Name = "عنوان سایت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string Title { get; set; }

        [Display(Name = "تعداد در صفحه  ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public int PageNumber { get; set; }

        [Display(Name = " Smtp")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string Smtp { get; set; }

        [Display(Name = "ایمیل ")]
        [RegularExpression(@"[\w_\-\.]+[@][\w_\-\.]+[\.][\w]{2,7}", ErrorMessage = ErrorMsg.RegeMsg)]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string Email { get; set; }

        [Display(Name = " کلمه عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string Password { get; set; }

        [Display(Name = " شماره پیامک ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string SmsService { get; set; }
        [Display(Name = " نام کاربری پیامک ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string SmsUser { get; set; }
        [Display(Name = " کلمه عبور پیامک")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string SmsPassword { get; set; }
        public string Telegram { get; set; }
        public string Instagram { get; set; }
    }
}
