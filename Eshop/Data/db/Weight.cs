using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class Weight : EntityBase
    {
        public Weight()
        {
        }

        public Nullable<int> Weight_Max { get; set; }
        public Nullable<int> Weight_Min { get; set; }
        public Nullable<int> Weight_Price { get; set; }
    }
}
