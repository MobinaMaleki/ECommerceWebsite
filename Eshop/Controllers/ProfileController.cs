using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.Data;
using Eshop.Data.db;
using Eshop.Models;
using Eshop.Repository;
using Eshop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Controllers
{
    [Authorize(Roles = "Customer")]
    public class ProfileController : Controller
    {
        ApplicationDbContext db ;
        private ISms _sms;
        private RepoProfile _repoProfile;
        public ProfileController(ISms sms)
        {
            _sms = sms;
            _repoProfile = new RepoProfile();
            db = new ApplicationDbContext();
        }
        public IActionResult Index()
        {
            ApplicationDbContext dbcontext = new ApplicationDbContext();
           ViewBag.userlogin= dbcontext.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault(); 
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProfile(ApplicationUser model)
        {
            ApplicationUser US = new ApplicationUser();

            
            var UserOnDB = db.Users.Where(a => a.UserName == User.Identity.Name).FirstOrDefault();
            UserOnDB.Address = model.Address;
            UserOnDB.City = model.City;
            UserOnDB.Country = model.Country;
            UserOnDB.Province = model.Province;
            UserOnDB.IrCode = model.IrCode;
            UserOnDB.PostalCode = model.PostalCode;
            UserOnDB.PhoneNumber = model.PhoneNumber;
            UserOnDB.ConformMobileCode = GetrandomCode();
            db.Users.Update(UserOnDB);
           
            db.SaveChanges();


            _sms.Send(model.PhoneNumber, GetrandomCode());

            return RedirectToAction("index","Profile");

        }

        private string GetrandomCode()
        {
            return "1550";
        }

        [HttpGet]
        public ActionResult GetPhoneNumberForSms()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult SendSms(string _phonenumber)
        //{

            //string codeverifi = string.Format("کد تایید شما: {0}", 1212);
            //_sms.Send(_phonenumber, codeverifi);

            //_repoProfile.SetConfirmMobile(User.Identity.Name, "1212");
            
        //}

        [HttpPost]
        public IActionResult CheckConfirmCode(string Code = null)
        {
            if (string.IsNullOrWhiteSpace(Code))
                return RedirectToAction(nameof(Index));

            var res = _repoProfile.CheckConfirmMobile(User.Identity.Name, Code);

            if (res)

            {
                var m=db.Users.Where(x => x.ConformMobileCode == Code).FirstOrDefault();
                m.PhoneNumberConfirmed = true;
                db.Users.Update(m);
                db.SaveChanges();

                return RedirectToAction("index", "home");
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }


        }

        [HttpGet]
        public IActionResult Message()
        {
            List<Messages> q= new List<Messages>();
            ViewBag.Message = db.Tbl_Message.Where(x => x.UserNameSend == User.Identity.Name).ToList();

            List<Messages> lstmsg = new List<Messages>();
            lstmsg = db.Tbl_Message.Where(x => x.UserNameSend == User.Identity.Name).ToList();
            string s = "";
            string condition = "";
            foreach (var item in lstmsg)
            {
                if (item.Confirm==true)
                {
                    condition = "خوانده شده";
                }
                else
                {
                    condition = "خوانده نشده";
                }
                s += string.Format("<tr>"
                   + "<td>{0}</td>"
                  + "<td>{1}</td>"
                   + "<td>{2}</td>"
                  + "</tr>", item.Text, item.InsertedDate,  condition);


            }
            ViewBag.msglist = s;



            return View();

        }
        [HttpPost]
        public void SendMsgtoAdmin(string Text) 
        {
           
            string msg = Text;

           string _RoleId= db.Roles.Where(x => x.Name == "Admin").FirstOrDefault().Id;
          
            string from =db.Users.Where(x=>x.UserName== User.Identity.Name).FirstOrDefault().Id;
            Messages _msg = new Messages();
            _msg.Confirm = false;
            _msg.Text = Text;
            _msg.UserIDSend = from;
            _msg.UserIDResived = _RoleId;
            _msg.InsertedDate = DateTime.Now;
            _msg.UserNameSend = User.Identity.Name;
            db.Tbl_Message.Add(_msg);
            db.SaveChanges();

        }
        public ActionResult ResetPassword()
        {
            return View();
        }
       


    }
}