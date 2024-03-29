﻿using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP.NET_Core_BookStore.Models;
using ASP.NET_Core_BookStore.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace ASP.NET_Core_BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;
        IUnitOfWork unitOfWork;

        enum Categories
        {
            Programming = 1,
            Psyhology = 2,
            Literature = 3,
            Medical = 4,
            Fantastic = 5
        }

        public BooksController(ILogger<BooksController> logger, IUnitOfWork context)
        {
            _logger = logger;
            unitOfWork = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("AllFavoriteBooks");
        }

        public async Task<IActionResult> AllFavoriteBooks(int page = 1)
        {
            int pageSize = 6;   // количество элементов на странице

            IQueryable<Book> source = unitOfWork.Books.GetAllFavoriteBooks();
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Books = items
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AllBooks(string search, int page = 1)
        {
            int pageSize = 6;   // количество элементов на странице

            IQueryable<Book> source = unitOfWork.Books.GetAll().Where(item => item.Name.Contains(search));
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Books = items
            };
            return View(viewModel);
        }

        public async Task<IActionResult> AllBooks(int page = 1)
        {
            int pageSize = 12;   // количество элементов на странице

            IQueryable<Book> source = unitOfWork.Books.GetAll();
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Books = items
            };
            return View(viewModel);
        }

        public async Task<IActionResult> AllProgrammingBooks(int page = 1)
        {
            int pageSize = 6;   // количество элементов на странице

            IQueryable<Book> source = unitOfWork.Books.GetAllBooksByCategory((int)Categories.Programming);
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Books = items
            };
            return View(viewModel);
        }

        public async Task<IActionResult> AllPsyhologyBooks(int page = 1)
        {
            int pageSize = 6;   // количество элементов на странице

            IQueryable<Book> source = unitOfWork.Books.GetAllBooksByCategory((int)Categories.Psyhology);
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Books = items
            };
            return View(viewModel);
        }

        public async Task<IActionResult> AllLiteratureBooks(int page = 1)
        {
            int pageSize = 6;   // количество элементов на странице

            IQueryable<Book> source = unitOfWork.Books.GetAllBooksByCategory((int)Categories.Literature);
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Books = items
            };
            return View(viewModel);
        }


        public async Task<IActionResult> AllMedicalBooks(int page = 1)
        {
            int pageSize = 6;   // количество элементов на странице

            IQueryable<Book> source = unitOfWork.Books.GetAllBooksByCategory((int)Categories.Medical);
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Books = items
            };
            return View(viewModel);
        }

        public async Task<IActionResult> AllFantasticBooks(int page = 1)
        {
            int pageSize = 6;   // количество элементов на странице

            IQueryable<Book> source = unitOfWork.Books.GetAllBooksByCategory((int)Categories.Fantastic);
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Books = items
            };
            return View(viewModel);
        }

        public IActionResult Basket()
        {
            var books = unitOfWork.Books.GetAllInBasket();
            return View(books);
        }

        [Authorize(Policy = "RequireAdministratorRole")]
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

        [Authorize(Policy = "RequireAdministratorRole")]
        [HttpGet]
        public IActionResult CreateBook()
        {
            return View();
        }

        [Authorize(Policy = "RequireAdministratorRole")]
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

        [Authorize(Policy = "RequireAdministratorRole")]
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

        [Authorize(Policy = "RequireAdministratorRole")]
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

        [Authorize(Policy = "RequireAdministratorRole")]
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
                if (item.InBasket)
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

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Delivery()
        {
            return View();
        }
    }
}
