using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data.db
{
    public class OtherServer : EntityBase
    {
        public string Title { get; set; }
        public string IP { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string HttpDomain { get; set; }

        public virtual ICollection<ViewImage> Tbl_ViewImage {  get; set; }
    }
}
