using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Services
{
    public interface ISms
    {
        public void Send(string PhoneNumber, string Body);
    }
}
