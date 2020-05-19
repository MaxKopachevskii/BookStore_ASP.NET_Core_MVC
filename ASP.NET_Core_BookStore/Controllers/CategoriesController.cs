using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_BookStore.Interfaces;
using ASP.NET_Core_BookStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_BookStore.Controllers
{
    [Authorize(Policy = "RequireAdministratorRole")]
    public class CategoriesController : Controller
    {
        IUnitOfWork unitOfWork;
        public CategoriesController(IUnitOfWork context)
        {
            unitOfWork = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllCategories()
        {
            return View(unitOfWork.Categories.GetAll());
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Categories.Create(category);
                unitOfWork.Save();
                return RedirectToAction("AllCategories");
            }
            return View();
        }

        [HttpGet]
        public IActionResult EditCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = unitOfWork.Categories.Get(id);
            if (category != null)
            {
                return View(category);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult EditCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Categories.Update(category);
                unitOfWork.Save();
                return RedirectToAction("AllCategories");
            }
            return View();
        }

        public IActionResult DeleteCategory(int id)
        {
            unitOfWork.Categories.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("AllCategories");
        }
    }
}