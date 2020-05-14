﻿using System;
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

        public BooksController(ILogger<BooksController> logger, IUnitOfWork context)
        {
            _logger = logger;
            unitOfWork = context;
        }

        public IActionResult Index()
        {
            CleanBasket();
            return RedirectToAction("AllFavoriteBooks");
        }

        public IActionResult AllBooks()
        {
            var books = unitOfWork.Books.GetAll();
            return View(books);
        }

        public IActionResult AllProgrammingBooks()
        {
            var books = unitOfWork.Books.GetAllProgrammingBooks();
            return View(books);
        }

        public IActionResult AllPsyhologyBooks()
        {
            var books = unitOfWork.Books.GetAllPsyhologyBooks();
            return View(books);
        }

        public IActionResult AllLiteratureBooks()
        {
            var books = unitOfWork.Books.GetAllLiteratureBooks();
            return View(books);
        }

        public IActionResult AllFavoriteBooks()
        {
            var books = unitOfWork.Books.GetAllFavoriteBooks();
            return View(books);
        }

        public IActionResult Basket()
        {
            var books = unitOfWork.Books.GetAllInBasket();
            return View(books);
        }

        public IActionResult AdminPanel()
        {
            var books = unitOfWork.Books.GetAll();
            return View(books);
        }

        public IActionResult BookInBasket(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = unitOfWork.Books.Get(id);
            if (book != null)
            {
                book.InBasket = true;
                unitOfWork.Books.Update(book);
                unitOfWork.Save();
                return RedirectToAction("DetailsBook", new { id = id});
            }
            return NotFound();
        }

        public IActionResult BookOutBasket(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = unitOfWork.Books.Get(id);
            if (book != null)
            {
                book.InBasket = false;
                unitOfWork.Books.Update(book);
                unitOfWork.Save();
                return RedirectToAction("Basket");
            }
            return NotFound();
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
