using ECommerceProject.Entity;
using ECommerceProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService categoryService = new CategoriesService();
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {
            var categories = categoryService.GetCategory();
            return View(categories);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryService.SaveCategory(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var categories = categoryService.GetCategoryById(ID);
            return View(categories);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryService.UpdateCategory(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var categories = categoryService.GetCategoryById(ID);
            return View(categories);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            categoryService.deleteCategory(category.ID);
            return RedirectToAction("Index");
        }
    }
}