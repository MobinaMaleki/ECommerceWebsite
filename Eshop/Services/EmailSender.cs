using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Eshop.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            SmtpClient smtpClient = new SmtpClient("mail.raheabrishami.com", 26);
            smtpClient.EnableSsl = false;
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new NetworkCredential("info@raheabrishami.com", "9aD=iRqcjAD7");


            MailMessage message = new MailMessage();

            message.From = new MailAddress("info@raheabrishami.com");
            message.To.Add(email);
            message.Subject = string.Format(subject);
            message.Body = string.Format(htmlMessage);
            message.IsBodyHtml = true;
            smtpClient.Send(message);

            return Task.FromResult(0);
        }
    }
}
