using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(100)]
        public string NameFamily { get; set; }

        [MaxLength(100)]
        public string Country { get; set; }

        [MaxLength(100)]
        public string Province { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(10)]
        public string IrCode { get; set; }

        public string ConformMobileCode { get; set; }
    }
}
