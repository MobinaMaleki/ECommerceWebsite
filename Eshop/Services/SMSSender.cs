using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Services
{
    public class SMSSender : ISms
    {
        public SMSSender()
        {

        }

        public void Send(string PhoneNumber, string Body)
        {

            const string username = "Saber_m";
            const string password = "1428";
            const string from = "30008666331821";

            string to = PhoneNumber;
            string text = Body;
            const bool isFlash = false;
            RestClient restClient = new RestClient(username, password);
            var result = restClient.Send(to, from, text, isFlash);

        }
    }
}
