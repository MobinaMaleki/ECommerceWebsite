using Eshop.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Repository
{
    public class RepRoleUser
    {
        private IdentityUserRole<string> _identityUserRole;
        ApplicationDbContext db;
        public RepRoleUser()
        {
            _identityUserRole = new IdentityUserRole<string>();
            db = new ApplicationDbContext();
        }
        public void AddRoleToUser(IdentityUserRole<string> identityUserRole)
        {
            db.UserRoles.Add(identityUserRole);
            db.SaveChanges();
        }

        public string GetRoleIDByRoleName(String RoleName)
        {
            String result = string.Empty;
            var rol = db.Roles.Where(a => a.Name == RoleName).FirstOrDefault();
            if (rol != null)
            {
                result = rol.Id;
            }
            return result;

        }

    }
}
