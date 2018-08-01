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
    [Produces("application/json")]
    [Route("api/category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        #region Ctor

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        #endregion
        // GET: api/Category
        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            return _categoryService.Get();
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "GetCategory")]
        public ActionResult<Category> Get(int id)
        {
            return _categoryService.Get(id);
        }

        // POST: api/Category
        [HttpPost]
        public ActionResult<Category> Post([FromBody]Category category)
        {
            return _categoryService.Create(category);
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Category category)
        {
            var existingCategory = _categoryService.Get(id);
            if (existingCategory == null)
                return NotFound();
            var updatedCategory = _categoryService.Update(category);
            return Ok(updatedCategory); // View("~/Views/Category/Index.cshtml")
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoryService.Delete(id);
        }
    }
}
