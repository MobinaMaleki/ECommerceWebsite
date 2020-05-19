using Eshop.Models.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class Comments : EntityBase
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "نام و نام خوانوادگی")]
        [MaxLength(50, ErrorMessage = ErrorMsg.MaxLengh)]
        public string NameFamily { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "ایمیل")]
        [MaxLength(50, ErrorMessage = ErrorMsg.MaxLengh)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "متن نظر")]
        [MaxLength(240, ErrorMessage = ErrorMsg.MaxLengh)]
        public string Text { get; set; }
        
        [Required]
        [Display(Name ="ای پی کاربر")]
        public string IP { get; set; }

        [Required]
        public bool Confirm { get; set; } = false;

        [ForeignKey(nameof(ProductID))]

        public virtual Products Tbl_Prodoct { get; set; }
    }
}
