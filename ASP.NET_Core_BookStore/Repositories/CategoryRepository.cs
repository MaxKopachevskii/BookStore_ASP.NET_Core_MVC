using ASP.NET_Core_BookStore.Interfaces;
using ASP.NET_Core_BookStore.Models;
using System.Linq;

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
            return db.Categories.Find(id);
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
