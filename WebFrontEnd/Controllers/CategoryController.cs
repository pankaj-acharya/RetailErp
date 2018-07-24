using System.Collections.Generic;
using ErpServices;
using Microsoft.AspNetCore.Mvc;

namespace WebFrontEnd.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
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
        public IEnumerable<string> Get() => new string[] { "value1", "value2" };

        // GET: api/Category/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            var category = _categoryService.GetCategoryById(1);
            return category.Name;
        }

        // POST: api/Category
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
