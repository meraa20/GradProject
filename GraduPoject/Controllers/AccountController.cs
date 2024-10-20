using Microsoft.AspNetCore.Mvc;
using GraduPoject.Models;
using GraduPoject.ViewModel;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GraduPoject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdUser> userManager;
        private readonly SignInManager<IdUser> signInManager;

        public AccountController(UserManager<IdUser> userManager, SignInManager<IdUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public DbContexxt context = new DbContexxt();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVm login)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(login.Email);
                if (user != null)
                {
                    if (await userManager.CheckPasswordAsync(user, login.Password))
                    {
                        await signInManager.SignInAsync(user, true);
                        return RedirectToAction("Index2", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Wrong Data");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Wrong Data");
                }
            }
            return View(login);
        }

        public IActionResult Sign_up()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Sign_up(Sign_upVm sign)
        {
            if (ModelState.IsValid)
            {
                // التحقق مما إذا كان البريد الإلكتروني موجودًا بالفعل
                var existingUser = await userManager.Users.FirstOrDefaultAsync(u => u.Email == sign.Email);
                if (existingUser != null)
                {
                    ModelState.AddModelError("", "Email already exists. Please use a different email.");
                    return View(sign);
                }

                IdUser idUser = new IdUser
                {
                    UserName = sign.Name,
                    Email = sign.Email,
                    PhoneNumber = sign.Phone
                };

                IdentityResult result = await userManager.CreateAsync(idUser, sign.Password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(idUser, "User");
                    return RedirectToAction("Index2", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                        Console.WriteLine($"Error creating user: {error.Description}");
                    }
                }
            }
            return View(sign);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ForgetPass()
        {
            return View();
        }

        public IActionResult Reset()
        {
            return View();
        }
    }
}
