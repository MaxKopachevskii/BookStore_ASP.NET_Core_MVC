using ASP.NET_Core_BookStore.Interfaces;
using ASP.NET_Core_BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_BookStore.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        BookStoreDbContext db;
        public OrderRepository(BookStoreDbContext context)
        {
            db = context;
        }

        public IEnumerable<Order> GetAll()
        {
            return db.Orders.ToList();
        }

        public Order Get(int? id)
        {
            var order = db.Orders.Find(id);
            return order;
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
