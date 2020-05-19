using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class Messages : EntityBase
    {
        public string UserIDSend { get; set; }
        public string UserIDResived { get; set; }
        public string UserNameSend { get; set; }
        public string Text { get; set; }
        public bool Confirm { get; set; }

    }
}
