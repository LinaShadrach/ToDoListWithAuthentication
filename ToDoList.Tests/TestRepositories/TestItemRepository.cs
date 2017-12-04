using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.Models;
using ToDoList.Models.Repositories;

namespace ToDoList.Tests.TestRepositories
{
    public class TestItemRepository : IItemRepository
    {
        public TestItemRepository()
        {
        }

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
