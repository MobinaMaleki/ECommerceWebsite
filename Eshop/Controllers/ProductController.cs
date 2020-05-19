using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Eshop.Data;
using Eshop.Data.db;
using Eshop.Repository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{


    public class ProductController : Controller
    {
        IRepository<Products> _reproduct;


        public ProductController()
        {
            _reproduct = new RepoProduct();

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Product()
        {

            return View();
        }
        [HttpPost]
        public void GetProductFromDB(string id)
        {



        }
        public ActionResult DetailProduct(int id)
        {
            int PID = id;

            RepoProduct repoProduct = new RepoProduct();

            var Prodoct = repoProduct.GetFullProductByID(PID);
            ViewBag.Product = Prodoct;
            ViewBag.ProductPictureDefult = Prodoct.Tbl_Gallery.Where(x => x.Defult == true).SingleOrDefault().PictureName;

            ViewBag.TechnicalInfo = Prodoct.Tbl_TechnicalDetails.FirstOrDefault();




            return View();
        }



    }
}
