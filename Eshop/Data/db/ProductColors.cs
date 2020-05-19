using Eshop.Models.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class ProductColors : EntityBase
    {

        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "رنگ")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "کد رنگ")]
        public string ColorCode { get; set; }

    

        public virtual ICollection<TechnicalsDetails> Tbl_TechnicalsDetails { get; set; }
    }
}
