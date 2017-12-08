using System;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.ViewModels;

namespace ToDoList.Models.Repositories
{
    public interface IAppUserRepository
    {
        Task<bool> Register(RegisterViewModel model);
        Task<bool> Login(LoginViewModel model);
        Task<bool> Logoff(AppUser user);
    }
}
