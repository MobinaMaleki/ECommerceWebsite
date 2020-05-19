using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class UserPages : EntityBase
    {
        public Guid RoelID { get; set; }
        public bool EditePost { get; set; }
        public bool DeletePost { get; set; }
        public bool AddPost { get; set; }
        public string PageNameEn { get; set; }
        public string PageNameFa { get; set; }
        public string ControllerName { get; set; }
    }
}
