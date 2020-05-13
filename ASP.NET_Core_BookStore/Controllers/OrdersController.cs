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
                unitOfWork.Orders.Create(order);
                unitOfWork.Save();
                return RedirectToAction("AllBooks");
            }
            return View();
        }

        public IActionResult GetAllOrders()
        {
            var orders = unitOfWork.Orders.GetAll();
            return View(orders);
        }

    }
}