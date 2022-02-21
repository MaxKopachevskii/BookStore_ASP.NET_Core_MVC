using ASP.NET_Core_BookStore.Interfaces;
using ASP.NET_Core_BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ASP.NET_Core_BookStore.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        BookStoreDbContext db;

        public BookRepository(BookStoreDbContext context)
        {
            db = context;
        }

        public IQueryable<Book> GetAll()
        {
            return db.Books.Include(m => m.Category);
        }

        public IQueryable<Book> GetAllBooksByCategory(int categoryId)
        {
            return db.Books.Include(m => m.Category).Where(item => item.CategoryId == categoryId);
        }

        public IEnumerable<Book> GetAllInBasket()
        {
            return db.Books.Include(m => m.Category).Where(item => item.InBasket == true).ToList();
        }

        public IQueryable<Book> GetAllFavoriteBooks()
        {
            return db.Books.Include(m => m.Category).Where(item => item.IsFavorite == true);
        }

        public Book Get(int? id)
        {
            return db.Books.Include(m => m.Category).FirstOrDefault(item => item.Id == id);
        }

        public void Create(Book item)
        {
            db.Books.Add(item);
        }

        public void Update(Book item)
        {
            db.Books.Update(item);
        }

        public void Delete(int id)
        {
            var book = db.Books.Find(id);
            if (book != null)
            {
                db.Books.Remove(book);
            }
        }
    }
}
