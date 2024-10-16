using Microsoft.AspNetCore.Mvc;

namespace GraduPoject.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult notification()
        {
            return View();
        }
    }
}
