using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace StateControl
{
    public class mail
    {
        public void Mail(string sendMailAdress,string subject,string body)
        {
            SmtpClient client = new SmtpClient();
            MailAddress from = new MailAddress("elfulutas@gmail.com");
            MailAddress to = new MailAddress("elfuluts@gmail.com");
            MailMessage msg = new MailMessage(from, to);
            msg.IsBodyHtml = true;
            msg.Subject = subject;
            msg.Body += "Gönderen Mail Adresi" + to + " | <h1> " + body + "</h1>";
            msg.CC.Add(sendMailAdress);
            NetworkCredential info = new NetworkCredential("elfulutas@gmail.com", "Seka2461.");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = info;
            client.Send(msg);

        }
    }
}