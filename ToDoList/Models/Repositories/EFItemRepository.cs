﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Models.Repositories
{
    public class EFItemRepository : IItemRepository
    {
        ToDoListDbContext db = new ToDoListDbContext();
        public IQueryable<Item> Items
        { get { return db.Items; } }

        public Item Save(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return item;
        }

        public Item Edit(Item item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return item;
        }

        public void Remove(Item item)
        {
            db.Items.Remove(item);
            db.SaveChanges();
        }
    }
}
