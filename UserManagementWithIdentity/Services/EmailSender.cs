using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace UserManagementWithIdentity.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var FromMail = "mohammed.s.alhadik@gmail.com";
            var FromPassword = "fyzmpilflpvvymmt";


            var message = new MailMessage();
            message.Subject = subject;
            message.Body =$"<html><body> {htmlMessage}</html></body> ";
            message.From =new MailAddress( FromMail);
            message.To.Add(email);
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(FromMail, FromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(message);
           

        }
    }
}
