using Eshop.Models.Plugin;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class Articles : EntityBase
    {
        public Articles()
        {
        }

        [Key]
        public override int ID { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "عنوان مقاله")]
        [MaxLength(150, ErrorMessage = ErrorMsg.MaxLengh)]
        public string Title { get; set; }
        
        [Required]
        [Display(Name = "تعداد بازدید")]
        public int View { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "توضیح مقاله")]
        [MaxLength(250, ErrorMessage = ErrorMsg.MaxLengh)]
        public string Description { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        [Display(Name = "متن مقاله")]        
        public string Text { get; set; }
        
        [Display(Name = "تصویر مقاله")]        
        public string PictureName { get; set; }
        public override DateTime InsertedDate { get; set; }


    }
}
