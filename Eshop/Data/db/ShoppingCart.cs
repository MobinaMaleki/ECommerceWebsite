using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class ShoppingCart : EntityBase
    {
       
        [Required]
        [Display(Name = " شناسه محصول")]
        public int Productid { get; set; }
        [Required]
        [Display(Name = " کد محصول")]
        public int ProductCode { get; set; }
        [Required]
        [Display(Name = " خریدار")]
        public string Userid { get; set; }
        [Required]
        [Display(Name = " تاریخ خرید")]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = " وضعیت")]
        public bool Status { get; set; }

        [Required]
        [Display(Name = " تعداد")]
        public int Count { get; set; }
    

        [Display(Name = " مبلغ پرداختی")]
        [Required]
        [MaxLength(15)]
        public string Price { get; set; }

        [Display(Name = " هزینه پست")]
        [Required]
        [MaxLength(15)]
        public string AmountSent { get; set; }
        [Display(Name = " مالیات")]
        [Required]
        [MaxLength(15)]
        public string Tax { get; set; }

        [Display(Name = " گارانتی انتخابی")]
        [Required]
        [MaxLength(100)]
        public string Warranty { get; set; }


        [ForeignKey(nameof(Userid))]
        public virtual ApplicationUser Tbl_User { get; set; }
        [ForeignKey(nameof(Productid))]
        public virtual Products Tbl_Product { get; set; }
    }
}
