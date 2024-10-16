using Microsoft.AspNetCore.Mvc;

namespace GraduPoject.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View("AboutUs");
        }
    }
}
