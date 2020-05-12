using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP.NET_Core_BookStore.Models;
using ASP.NET_Core_BookStore.Interfaces;

namespace ASP.NET_Core_BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;
        IUnitOfWork unitOfWork;

        public BooksController(ILogger<BooksController> logger,IUnitOfWork context)
        {
            _logger = logger;
            unitOfWork = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllBooks()
        {
            var books = unitOfWork.Books.GetAll();
            return View(books);
        }

        public IActionResult AdminPanel()
        {
            var books = unitOfWork.Books.GetAll();
            return View(books);
        }

        [HttpGet]
        public IActionResult CreateBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Books.Create(book);
                unitOfWork.Save();
                return RedirectToAction("AdminPanel");
            }
            return View();
        }

        [HttpGet]
        public IActionResult EditBook(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = unitOfWork.Books.Get(id);
            if (book != null)
            {
                return View(book);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Books.Update(book);
                unitOfWork.Save();
                return RedirectToAction("AdminPanel");
            }
            return View();
        }

        public IActionResult DetailsBook(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = unitOfWork.Books.Get(id);
            if (book != null)
            {
                return View(book);
            }
            return NotFound();
        }

        public IActionResult DeleteBook(int id)
        {
            unitOfWork.Books.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("AdminPanel");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
