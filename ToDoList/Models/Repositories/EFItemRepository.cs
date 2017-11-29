using System;
using System.Linq;

namespace ToDoList.Models.Repositories
{
    public class EFItemRepository : IItemRepository
    {
        ToDoListDbContext db = new ToDoListDbContext();

        public IQueryable<Item> Items { get; }

        public Item Edit(Item item)
        {
            throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            throw new NotImplementedException();
        }

        public Item Save(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
