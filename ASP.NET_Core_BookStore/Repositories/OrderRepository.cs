using ASP.NET_Core_BookStore.Interfaces;
using ASP.NET_Core_BookStore.Models;
using Microsoft.EntityFrameworkCore;
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

        public IQueryable<Order> GetAll()
        {
            return db.Orders.Include(m => m.OrderBooks);
        }

        public Order Get(int? id)
        {
            var orders = db.Orders.Include(m => m.OrderBooks).ToList();
            var order = orders.FirstOrDefault(item => item.Id == id);
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
