using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpModel;
using ErpServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebFrontEnd.Controllers
{
    public class backup-CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        #region Ctor

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        #endregion

        // GET: Category
        public ActionResult Index()
        {
            List<Category> categoryList = _categoryService.GetAllCategories();
            return View(categoryList);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            Category category = _categoryService.GetCategoryById(id);
            return View(category);
        }


        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            //Get latest product info from DB in case it has been updated 
            Category category = _categoryService.GetCategoryById(id);
            return View(category);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
