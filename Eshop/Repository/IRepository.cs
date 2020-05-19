using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Repository
{
    public interface IRepository<T>
    {
        T add(T Entity);
        void Update(T Entity);
        void Delete(string ID);
        List<T> SelectAll();
        T GetByID(int ID);

    }
}
