using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ToDoList.ViewModels;

namespace ToDoList.Models.Repositories
{
    public class EFAppUserRepository : IAppUserRepository
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public EFAppUserRepository(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            if (userManager == null)
            {
                _userManager = userManager;
                _signInManager = signInManager;
            }
        }

        public EFAppUserRepository()
      : this(new UserManager<AppUser>(new UserStore<AppUser>(new ToDoListDbContext())))
    {
        }


        //public IQueryable<AppUser> AppUsers
        //{ get { return _db.AppUsers; } }
        public AppUser Login(LoginViewModel user)
        {
            throw new NotImplementedException();
        }

        public void LogOff()
        {
            throw new NotImplementedException();
        }

        public async Task<AppUser> Register(RegisterViewModel user)
        {
            AppUser foundUser = new AppUser { UserName = user.Email };
            IdentityResult result = await _userManager.CreateAsync(foundUser, user.Password);
            return foundUser;
        }
    }
}
