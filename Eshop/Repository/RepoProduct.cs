using Eshop.Data;
using Eshop.Data.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Eshop.Repository
{
    public class RepoProduct : IRepository<Products>
    {
        ApplicationDbContext db;
        public RepoProduct()
        {
            db = new ApplicationDbContext();
        }

        public Products add(Products Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(string ID)
        {
            throw new NotImplementedException();
        }

        public Products GetByID(int ID)
        {
            var res = db.Tbl_Products.Where(x => x.ID == ID).FirstOrDefault();
            return res;
        }

        public Products GetFullProductByID(int ID)
        {
            var res = db.Tbl_Products.Where(x => x.ID == ID).Include(x => x.Tbl_Gallery).Include(y => y.Tbl_Category).Include(z=>z.Tbl_TechnicalDetails).FirstOrDefault();
            return res;
        }

        public List<Products> SelectAll()
        {

            var res = db.Tbl_Products.Include(x => x.Tbl_Gallery).ToList();

            return res;


        }

        public void Update(Products Entity)
        {
            throw new NotImplementedException();
        }





    }
}
