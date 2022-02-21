using ASP.NET_Core_BookStore.Interfaces;
using ASP.NET_Core_BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASP.NET_Core_BookStore.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        BookStoreDbContext db;
        public OrderRepository(BookStoreDbContext context)
        {
            db = context;
        }

        public IQueryable<Order> GetAll()
        {
            return db.Orders.Include(m => m.OrderBooks);
        }

        public Order Get(int? id)
        {
            return db.Orders.Include(m => m.OrderBooks).FirstOrDefault(item => item.Id == id);
        }

        public void Create(Order item)
        {
            db.Orders.Add(item);
        }

        public void Update(Order item)
        {
            db.Orders.Update(item);
        }

        public void Delete(int id)
        {
            var order = db.Orders.Find(id);
            if (order != null)
            {
                db.Orders.Remove(order);
            }
        }
    }
}
