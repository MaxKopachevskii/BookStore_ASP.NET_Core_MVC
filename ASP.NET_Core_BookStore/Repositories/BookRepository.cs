using ASP.NET_Core_BookStore.Interfaces;
using ASP.NET_Core_BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public IQueryable<Book> GetAllProgrammingBooks()
        {
            return db.Books.Include(m => m.Category).Where(item => item.CategoryId == 1);
        }

        public IQueryable<Book> GetAllPsyhologyBooks()
        {
            return db.Books.Include(m => m.Category).Where(item => item.CategoryId == 2);
        }

        public IQueryable<Book> GetAllLiteratureBooks()
        {
            return db.Books.Include(m => m.Category).Where(item => item.CategoryId == 3);
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
            var books = db.Books.Include(m => m.Category).ToList();
            var book = books.FirstOrDefault(item => item.Id == id);
            return book;
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
