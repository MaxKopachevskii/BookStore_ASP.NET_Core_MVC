using ASP.NET_Core_BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_BookStore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Book> Books { get; }
        IRepository<Category> Categories { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }
}
