using System;
using Microsoft.AspNetCore.Identity;

namespace ToDoList.Models.Repositories
{
    public interface IUserManager
    {
        UserManager<AppUser> _userManager { get; }
    }
}
