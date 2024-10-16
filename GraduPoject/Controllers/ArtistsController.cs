using Microsoft.AspNetCore.Mvc;

namespace GraduPoject.Controllers
{
    public class ArtistsController : Controller
    {
        public IActionResult ArtistFollow()
        {
            return View();
        }
        public IActionResult Artist()
        {
            return View();
        }
    }
}
