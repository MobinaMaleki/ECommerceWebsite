using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public abstract class EntityBase 
    {
        [Key]
        public virtual int ID { get; set; }
        public virtual DateTime  InsertedDate { get; set; }
    }
}
