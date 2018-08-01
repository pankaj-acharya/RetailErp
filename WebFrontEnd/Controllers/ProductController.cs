using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpModel;
using ErpServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace WebFrontEnd.Controllers
{
    [Produces("application/json")]
    [Route("api/product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/Product
        [HttpGet]
        public IEnumerable<Product> Get()
        {
           return _productService.Get();
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "GetProduct")]
        [ProducesResponseType(200, Type = typeof(Product))]
        [ProducesResponseType(404)]
        public IActionResult Get(int id)
        {
            var product= _productService.Get(id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        // POST: api/Product
        [HttpPost]
        public ActionResult<Product> Post([FromBody]Product product)
        {
            //TODO:Add validation to cover different possible HTTP status types
            return  _productService.Create(product);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Product product)
        {
            var existingProduct = _productService.Get(id);
            if (existingProduct == null)
                return NotFound();
            var updatedProduct= _productService.Update(product);
            return Ok(updatedProduct); // View("~/Views/Product/Index.cshtml")
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           
            _productService.Delete(id);
            return new StatusCodeResult(200);//Check the status code for deletion
        }
    }
}
