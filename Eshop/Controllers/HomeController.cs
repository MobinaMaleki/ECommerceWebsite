using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Eshop.Models;
using System.Net.Mail;
using System.Net;
using Eshop.Data;
using Microsoft.AspNetCore.Identity;
using Eshop.Data.db;

namespace Eshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            

            //ApplicationDbContext _con = new ApplicationDbContext();
            
            //_con.Roles.Add(new Microsoft.AspNetCore.Identity.IdentityRole() { Name = "Customer" });
            //_con.Roles.Add(new Microsoft.AspNetCore.Identity.IdentityRole() { Name = "Admin" });
            //_con.Roles.Add(new Microsoft.AspNetCore.Identity.IdentityRole() { Name = "User" });
            //_con.SaveChanges();
            //var a = User.Identity.IsAuthenticated;

     

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contactus()
        {

            return View();
        }
    }
}
