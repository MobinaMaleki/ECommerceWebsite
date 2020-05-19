using Eshop.Models.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class Gallery : EntityBase
    {
        [Display(Name = "شناسه محصول")]

        public int ProductID { get; set; }
        //public int UserID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "توضیح")]
        [MaxLength(50, ErrorMessage = ErrorMsg.MaxLengh)]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "نام تصویر")]
        [MaxLength(50, ErrorMessage = ErrorMsg.MaxLengh)]
        public string PictureName { get; set; }

        [Required]
        public bool Defult { get; set; }

        //public int ViewImageID { get; set; }

        //[Display(Name ="بارگذاری روی سور دیگر")]
        //public bool ServerUpload { get; set; }

       //[ForeignKey(nameof(ViewImageID))]
       // public virtual ViewImage Tbl_Images { get; set; }


        [ForeignKey(nameof(ProductID))]
        public virtual Products  Tbl_Product { get; set; }
    }
}
