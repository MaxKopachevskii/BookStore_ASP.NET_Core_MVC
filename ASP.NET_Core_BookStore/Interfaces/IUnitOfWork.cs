using ASP.NET_Core_BookStore.Repositories;
using System;

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
