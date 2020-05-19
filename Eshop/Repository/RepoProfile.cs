using Eshop.Data;
using Eshop.Data.db;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Eshop.Repository
{
    public class RepoProfile
    {
        ApplicationDbContext db;
        public RepoProfile()
        {
            db = new ApplicationDbContext();
        }


        public bool IsAddressInDb(string Username)
        {
            try
            {
                var ad = GetUserByUserName(Username);
                if (string.IsNullOrWhiteSpace(ad.City) &&
                    string.IsNullOrWhiteSpace(ad.Address) &&
                    string.IsNullOrWhiteSpace(ad.Province) &&
                    string.IsNullOrWhiteSpace(ad.PostalCode) &&
                    string.IsNullOrWhiteSpace(ad.Country) &&
                    string.IsNullOrWhiteSpace(ad.IrCode))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public bool IsConfirmMobile(string Username)
        {
            var RegisterdUser = GetUserByUserName(Username);
            return RegisterdUser.PhoneNumberConfirmed;

        }
        public bool CheckConfirmMobile(string Username, string ConfirmCode)
        {
            bool res = false;
            var RegisterdUser = GetUserByUserName(Username);
            if (RegisterdUser.ConformMobileCode == ConfirmCode)
                res = true;
            else
                res = false;

            RegisterdUser.PhoneNumberConfirmed = res;
            db.Users.Update(RegisterdUser);
            db.SaveChanges();

            return res;

        }

        public void SetConfirmMobile(string Username, string ConfirmCode)
        {
            var RegisterdUser = GetUserByUserName(Username);
            RegisterdUser.ConformMobileCode = ConfirmCode;
            db.Users.Update(RegisterdUser);
            db.SaveChanges();

        }

        public ApplicationUser GetUserByUserName(string Username)
        {
            return db.Users.Where(x => x.UserName == Username).FirstOrDefault();

        }

    }
}
