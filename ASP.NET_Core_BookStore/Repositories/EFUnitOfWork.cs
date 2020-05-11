using ASP.NET_Core_BookStore.Interfaces;
using ASP.NET_Core_BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_BookStore.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        BookStoreDbContext db;
        BookRepository bookRepository;
        CategoryRepository categoryRepository;
        OrderRepository orderRepository;
        public EFUnitOfWork(BookStoreDbContext context)
        {
            db = context;
        }

        public IRepository<Book> Books
        {
            get
            {
                if (bookRepository == null)
                    bookRepository = new BookRepository(db);
                return bookRepository;
            }
        }

        public IRepository<Category> Categories
        {
            get
            {
                if (categoryRepository == null)
                    categoryRepository = new CategoryRepository(db);
                return categoryRepository;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(db);
                return orderRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
