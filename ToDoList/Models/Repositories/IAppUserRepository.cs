using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ToDoList.ViewModels;

namespace ToDoList.Models.Repositories
{
    public interface IAppUserRepository
    {
        //IQueryable<AppUser> AppUsers { get; }
        AppUser Login(LoginViewModel user);
        Task<AppUser> Register(RegisterViewModel user);
        void LogOff();
    }
}
