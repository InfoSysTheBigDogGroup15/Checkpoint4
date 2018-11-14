using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        public static SmtpClient SendEmail = new SmtpClient();

        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.output = "<center><h2>Please call Support at <b><u>801-555-1212</u></b>. Thank you!</h2></center>";
            return View();
        }
        [Route("Contact/email")]
        [Route("Contact/Email/{id}/{id}")]
        [Route("Test")] 
        public ActionResult Email(string name, string email)
        {
            ViewBag.output = "<center><h2>Thank you <b>" + name + "</b>. We will send an email to <b>" + email + "</b></h2></center>";
            if (name != null && email != null)
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.UseDefaultCredentials = false;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("blowoutinstrument@gmail.com", "infosystem403");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("blowoutinstrument@gmail.com", "noreply");
                mail.To.Add(new MailAddress(email));
                mail.CC.Add(new MailAddress("blowoutinstrument@gmail.com"));
                mail.Subject = "Contact Recorded";
                mail.Body = "Thank you " + name + ", for contacting BlowOut Instrument Rentals! Please allow 2-3 business days for processing.";
                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;
                smtpClient.Send(mail);
            }
            return View("Index");
        }
    }
}