using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using WebApp.Helpers.Services;
using WebApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly AuthenticationService _authenticationService;

        public AccountController(UserManager<UserEntity> userManager, AuthenticationService authenticationService)
        {
            _userManager = userManager;
            _authenticationService = authenticationService;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register (RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (!await _userManager.Users.AnyAsync(x => x.Email == viewModel.Email))
                {

                    if (await _authenticationService.RegisterAsync(viewModel))

                        return RedirectToAction("register", "login");

                }
                ModelState.AddModelError("", "User with the same email address already exists");

            }

            return View(viewModel);

        }








        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _authenticationService.LoginAsync(viewModel))
                    return RedirectToAction("login", "Home");

                ModelState.AddModelError("", "Incorrect email or password");
            }

            return View(viewModel);

        }



        [Authorize]
        public async Task<IActionResult> Logout()
        {
            if (await _authenticationService.LogoutAsync(User))
                return LocalRedirect("/");

            return RedirectToAction("Index", "Home");
        }
    }
}
