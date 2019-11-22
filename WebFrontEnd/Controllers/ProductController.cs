using System;
using System.Collections.Generic;
using ErpModel;
using ErpServices;
using Microsoft.AspNetCore.Mvc;

namespace WebFrontEnd.Controllers
{
    [Produces("application/json")]
    [Route("api/product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICartService _cartService;

        public ProductController(IProductService productService,ICartService cartService)
        {
            _productService = productService;
            _cartService = cartService;
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
        public ViewResult Get(int id)
        {
            var product= _productService.Get(id);
            if (product == null)
                return View("Error");
            return View("Details", product);
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
        
        [Route("Product/AddToBag")]
        public IActionResult AddToBag(int id)
        {

            //Read cartGuid from cookie
            string cookieValue;
            Request.Cookies.TryGetValue("cartguid",out cookieValue);

            #region Move this logic in CartService
            if (string.IsNullOrEmpty(cookieValue))
            {
                cookieValue = Guid.NewGuid().ToString();
                Response.Cookies.Append("cartguid", cookieValue, new Microsoft.AspNetCore.Http.CookieOptions { Expires = DateTime.Now.AddDays(1),IsEssential =true });
            }
            
            #endregion

            var userCart = _cartService.Add(id, 1, cookieValue);

            return new StatusCodeResult(200);
        }

        public IActionResult Edit()
        {
            throw new System.NotImplementedException();
        }
    }
}
