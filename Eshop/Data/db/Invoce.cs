using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class Invoce : EntityBase
    {
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
        [Required]
        [Display(Name = " شناسه سفارش")]
        public int InvoiceId { get; set; }
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
        [Display(Name = " شناسه تراکنش")]
        [MaxLength(100)]
        public string TransactionID { get; set; }
        [Display(Name = " شناسه مرجع")]
        [MaxLength(100)]
        public string ReferenceID { get; set; }
        [Display(Name = " شناسه محصول")]
        public int Productid { get; set; }
        
        [Required]
        [Display(Name = " کد محصول")]
        public int ProductCode { get; set; }

        [Required]
        [ForeignKey(nameof(Userid))]
        public virtual ApplicationUser Tbl_User { get; set; }
        [ForeignKey(nameof(Productid))]
        public virtual Products Tbl_Product { get; set; }
    }
}
