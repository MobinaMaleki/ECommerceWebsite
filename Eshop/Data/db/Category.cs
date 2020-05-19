using Eshop.Models.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class Category : EntityBase
    {
        public Category()
        {

        }

        [Key]
        public override int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "عنوان دسته بندی")]
        [MaxLength(150, ErrorMessage = ErrorMsg.MaxLengh)]
        public string Title { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "توضیح مقاله")]
        [MaxLength(250, ErrorMessage = ErrorMsg.MaxLengh)]
        public string Description { get; set; }

        [Display(Name = "فعال / غیر فعال")]
        public bool IsActive { get; set; } = true;

        public override DateTime InsertedDate { get; set; }
    }
}
