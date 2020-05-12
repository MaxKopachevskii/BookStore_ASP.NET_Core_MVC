using ASP.NET_Core_BookStore.Models;
using ASP.NET_Core_BookStore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_BookStore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        BookRepository Books { get; }
        CategoryRepository Categories { get; }
        OrderRepository Orders { get; }
        void Save();
    }
}
