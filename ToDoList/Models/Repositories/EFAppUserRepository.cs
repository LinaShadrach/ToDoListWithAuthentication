using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;
using ToDoList.ViewModels;

namespace ToDoList.Models.Repositories
{
    public class EFAppUserRepository : IAppUserRepository
    {
        ToDoListDbContext db = new ToDoListDbContext();
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;

        public EFAppUserRepository(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> Register(RegisterViewModel model)
        {

            AppUser user = new AppUser { UserName = model.Email, Email = model.Email };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Task<bool> Login(LoginViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Logoff(AppUser user)
        {
            throw new NotImplementedException();
        }
    }
}
