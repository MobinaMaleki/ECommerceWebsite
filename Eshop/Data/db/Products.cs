using Eshop.Models.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class Products : EntityBase
    {
       

        [Display(Name = "کد محصول ")]
        [MaxLength(20)]
        [Required]
        public string CodeProduct { get; set; }

        [Display(Name = "عنوان محصول ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RegeMsg)]
        [MaxLength(100, ErrorMessage = ErrorMsg.MaxLengh)]
        [MinLength(3, ErrorMessage = ErrorMsg.MinLengh)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessage = ErrorMsg.RegeMsg)]
        public string Title { get; set; }

        [Display(Name = "گروه محصول ")]
        public Nullable<int> CategoryId { get; set; }

        [Display(Name = "تعداد بازدید محصول ")]
        public int Visit { get; set; }

        [Display(Name = "قیمت محصول ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RegeMsg)]
        [MaxLength(12, ErrorMessage = ErrorMsg.MaxLengh)]
        public string Price { get; set; }

        [Display(Name = " درصد تخفیف ")]
        public Nullable<int> DiscountPercent { get; set; }

        [Display(Name = "قیمت با تخفیف ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RegeMsg)]
        [MaxLength(12, ErrorMessage = ErrorMsg.MaxLengh)]
        public string DiscountedPrice { get; set; }

        [Display(Name = "غیر فعالسازی/فعال ")]
        public bool ActiveInactive { get; set; }

        [Display(Name = "زمان ثبت")]
        public DateTime Date { get; set; }

        [Display(Name = "موجودی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RegeMsg)]
        public int Stock { get; set; }

        [Display(Name = "توضیحات")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RegeMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessage = ErrorMsg.RegeMsg)]
        public string Decrption { get; set; }

        [Display(Name = "وزن محصول")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RegeMsg)]
        public int Wieght { get; set; }

        [Display(Name = "فروشنده")]
        public string UserID { get; set; }

        public bool IsServerUpload { get; set; }

        //معرفی کلیدهای خارجی
        [ForeignKey(nameof(UserID))]
        public virtual ApplicationUser Tbl_User { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Tbl_Category { get; set; }

        //ایجاد ارتباط با جدول ها
        public virtual ICollection<Gallery> Tbl_Gallery { get; set; }
        public virtual ICollection<ShoppingCart> Tbl_ShopingCart { get; set; }
        public virtual ICollection<Comments> Tbl_Comment { get; set; }
        public virtual ICollection<ViewImage> Tbl_ViewImage { get; set; }
        public virtual ICollection<TechnicalsDetails> Tbl_TechnicalDetails { get; set; }
     
    }
}
