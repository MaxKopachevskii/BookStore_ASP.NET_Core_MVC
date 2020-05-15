using ASP.NET_Core_BookStore.Interfaces;
using ASP.NET_Core_BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_BookStore.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        BookStoreDbContext db;

        public CategoryRepository(BookStoreDbContext context)
        {
            db = context;
        }
        public IQueryable<Category> GetAll()
        {
            return db.Categories;
        }

        public Category Get(int? id)
        {
            var category = db.Categories.Find(id);
            return category;
        }

        public void Create(Category item)
        {
            db.Categories.Add(item);
        }

        public void Update(Category item)
        {
            db.Categories.Update(item);
        }

        public void Delete(int id)
        {
            var category = db.Categories.Find(id);
            if (category != null)
            {
                db.Categories.Remove(category);
            }
        }
    }
}
