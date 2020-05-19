using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class TechnicalsDetails : EntityBase
    {
      
        [Display(Name = "شناسه محصول")]
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = " رنگ")]
        public int ColorId { get; set; }
        [Required]
        [Display(Name = "جنس محصول")]
        [MaxLength(100)]
        public string Type { get; set; }
        [Display(Name = "شرکت سازنده ")]
        [MaxLength(100)]
        public string Factory { get; set; }
        [Display(Name = "کشور سازنده ")]
        [MaxLength(100)]
        public string MadeIn{ get; set; }
        [Display(Name = " مدل ")]
        [MaxLength(100)]
        public string Model { get; set; }
        [Display(Name = "سال تولید")]
        [MaxLength(100)]
        public string ProductionYear { get; set; }
        [Display(Name = "گارانتی ")]
        [MaxLength(100)]
        public string Warranty { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Products Tbl_Product { get; set; }

        [ForeignKey(nameof(ColorId))]
        public virtual ProductColors Tbl_Color { get; set; }



    }
}
