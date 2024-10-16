using Microsoft.AspNetCore.Mvc;

namespace GraduPoject.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View("contactUs");
        }
        public IActionResult terms()
        {
            return View("Terms and Conditions");
        }
    }
}
