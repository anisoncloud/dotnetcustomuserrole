using CustomUserRoll.Models;
using CustomUserRoll.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CustomUserRoll.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Users> _signInManager;
        private readonly UserManager<Users> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(SignInManager<Users> signInManager, UserManager<Users> userManager, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Logic to authenticate user
                // If successful, redirect to a secure area
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
        //public IActionResult Register()
        //{
        //    //return View();
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model) {
            if (ModelState.IsValid)
            {
                // Logic to register user
                // If successful, redirect to a secure area or login page
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
