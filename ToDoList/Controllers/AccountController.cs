
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Models.Repositories;
using ToDoList.ViewModels;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Controllers
{
    public class AccountController : Controller
    {

        private IAppUserRepository appUserRepo;
        public AccountController(IAppUserRepository thisRepo = null)
        {
            if(thisRepo==null){
                this.appUserRepo = new EFAppUserRepository();
            }
            else{
                this.appUserRepo = thisRepo;
            }

        }

        //public AccountController() { }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            Task<AppUser> user = appUserRepo.Register(model);
            if (user!=null)
            {
                return View("Index", "Items");
            }
            else
            {
                return View("Index", "Account");
            }
        }


        //[HttpPost]
        //public async Task<IActionResult> LoginOnRegister(AppUser user, string password)
        //{

        //    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user.Email, password, isPersistent: true, lockoutOnFailure: false);
        //    if (result.Succeeded)
        //    {

        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Register");
        //    }
        //}

        //public IActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
        //    if (result.Succeeded)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}

        //[HttpPost]
        //public async Task<IActionResult> LogOff()
        //{
        //    await _signInManager.SignOutAsync();
        //    return RedirectToAction("Index");
        //}

        public IActionResult HelloAjax()
        {
            return Content("Hello from the controller!", "text/plain");
        }

    }
}
