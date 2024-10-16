using Microsoft.AspNetCore.Mvc;
using  GraduPoject.Models;
using System.Diagnostics;
namespace GraduPoject.Controllers
{
    public class AccountController : Controller
    {
       public DbContexxt context= new DbContexxt();
        public IActionResult login()
        {
            if (ModelState.IsValid) {

            }
            return View("Login");
        }
        public IActionResult sign_up()
        {
            return View("Sign_up");
        }
        public IActionResult  ForgetPass ()
        {
            return View();
        }
        public IActionResult Reset()
        {
            return View();
        }
    }
}
