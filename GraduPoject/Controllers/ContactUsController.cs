using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;

namespace GraduPoject.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View("contactUs");
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(string name, string email, string message)
        {
            try
            {

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(email),
                    Subject = $"Contact Form Message from {name}",
                    Body = $"Name: {name}\nEmail: {email}\nMessage: {message}",
                    IsBodyHtml = false,
                };


                mailMessage.To.Add("tarbshaaska@gmail.com");


                using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.Credentials = new NetworkCredential("tarbshaaska@gmail.com", "pkox glza duat ltow");
                    smtpClient.EnableSsl = true;
                    await smtpClient.SendMailAsync(mailMessage);
                }

                TempData["Message"] = "Your message was sent successfully!";
            }
            catch (Exception ex)
            {
                TempData["Message"] = $"Failed to send the message. Error: {ex.Message}";
            }


            return RedirectToAction("Index");
        }

        public IActionResult terms()
        {
            return View("Terms and Conditions");
        }
    }
}
