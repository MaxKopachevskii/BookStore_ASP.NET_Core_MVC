using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_BookStore.Interfaces;
using ASP.NET_Core_BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_BookStore.Controllers
{
    public class OrdersController : Controller
    {
        IUnitOfWork unitOfWork;
        public OrdersController(IUnitOfWork context)
        {
            unitOfWork = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllOrders()
        {
            var orders = unitOfWork.Orders.GetAll();
            return View(orders);
        }

        [HttpGet]
        public IActionResult CreateOrderForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrderForm(Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderBooks = unitOfWork.Books.GetAllInBasket();
                unitOfWork.Orders.Create(order);
                unitOfWork.Save();
                Sales();
                CleanBasket();
                return RedirectToAction("AllBooks", "Books");
            }
            return View();
        }

        public IActionResult DetailsOrder(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = unitOfWork.Orders.Get(id);
            if (order != null)
            {
                return View(order);
            }
            return NotFound();
        }

        public IActionResult DeleteOrder(int id)
        {
            unitOfWork.Orders.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("AdminPanel","Books");
        }

        public void CleanBasket()
        {
            var books = unitOfWork.Books.GetAll();
            foreach (var item in books)
            {
                if (item.InBasket == true)
                {
                    item.InBasket = false;
                    unitOfWork.Books.Update(item);
                    unitOfWork.Save();
                }
            }
        }

        public void Sales()
        {
            var books = unitOfWork.Books.GetAll();
            foreach (var item in books)
            {
                if (item.InBasket == true)
                {
                    item.CountInStock--;
                    unitOfWork.Books.Update(item);
                    unitOfWork.Save();
                }
            }
        }

    }
}