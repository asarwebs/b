using cleaning.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace cleaning.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Estimate(string sname, string semail, string sphone)
        {
            int? samount = 100;
            var vm = new EstimateViewModel(sname, semail, sphone, samount);
            // return RedirectToAction("Confirmation", vm);
            return View("Confirmation", vm);
        }
        public async Task<ActionResult> Email(string sname, string semail, string smessage, string sphone)
        {
            var name = sname;
            var email = semail;
            var messages = smessage;
            var phone = sphone;
            var x = await SendEmail(name, email, messages, phone);
            if (x == "sent")
                ViewData["esent"] = "Your Message Has Been Sent";
            return RedirectToAction("Index");
        }
        private async Task<string> SendEmail(string sname, string semail, string smessage, string sphone)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress("asarwebs@gmail.com"));  // replace with receiver's email id  
            message.From = new MailAddress("asarwebs@gmail.com");  // replace with sender's email id 
            message.Subject = "Message From" + semail;
            message.Body = "Name: " + sname + "\nFrom: " + semail + "\nPhone: " + sphone + "\n" + smessage;
            message.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "asarwebs@gmail.com",  // replace with sender's email id 
                    Password = ""  // replace with password 
                };
                smtp.Credentials = credential;
                smtp.Host = " smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);
                return "sent";
            }
        }
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Confirmation(EstimateViewModel vm)
        //{
        //    return View(vm);
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}