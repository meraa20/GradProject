using GraduPoject.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraduPoject.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View("shop");
        }
        public IActionResult Order()
        {
            var cart = new Cart();

            return View(cart);
        }

       
    }
}
