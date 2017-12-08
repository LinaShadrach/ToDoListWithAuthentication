using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models.Repositories
{
    public class EFAppUserRepository : IAppUserRepository
    {
        ToDoListDbContext db = new ToDoListDbContext();
        public EFAppUserRepository(UserManager userManager, SignInManager signInManager, ToDoListDbContext db){
          
        }
        public IQueryable<AppUser> AppUsers
        { get { return db.AppUsers; } }

        public AppUser Save(AppUser item)
        {
            db.AppUsers.Add(item);
            db.SaveChanges();
            return item;
        }

        public AppUser Edit(AppUser item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return item;
        }

        public void Remove(AppUser item)
        {
            db.AppUsers.Remove(item);
            db.SaveChanges();
        }
    }
}
