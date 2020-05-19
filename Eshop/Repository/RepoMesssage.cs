using Eshop.Data;
using Eshop.Data.db;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Repository
{
    public class RepoMesssage
    {
        ApplicationDbContext db;

        public RepoMesssage()
        {
            db = new ApplicationDbContext();
        }

        public List<Messages> GetMessageSend(string UserName)
        {
            return db.Tbl_Message.Where(x => x.UserIDSend == UserName).ToList();
            
        }

    }
}
