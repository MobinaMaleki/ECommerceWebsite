using Eshop.Models.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Models
{
    public class AddressViewModel
    {
        [Display(Name = "کشور")]
        [MaxLength(20, ErrorMessage = ErrorMsg.MaxLengh)]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string Country { get; set; }

        [Display(Name = "شهر")]
        [MaxLength(50, ErrorMessage = ErrorMsg.MaxLengh)]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string City { get; set; }

        [Display(Name = "استان")]
        [MaxLength(50, ErrorMessage = ErrorMsg.MaxLengh)]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string Province { get; set; }

        [Display(Name = "آدرس")]
        [MaxLength(100, ErrorMessage = ErrorMsg.MaxLengh)]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string Address { get; set; }

        [Display(Name = "کد پستی")]
        [MaxLength(10, ErrorMessage = ErrorMsg.MaxLengh)]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string PostalCode { get; set; }

        [Display(Name = "کد ملی")]
        [MaxLength(10, ErrorMessage = ErrorMsg.MaxLengh)]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMsg.RequaredMsg)]
        public string IrCode { get; set; }

        public string UserName { get; set; }
        public string NameFamily { get; set; }
        public string Email { get; set; }
    }
}
