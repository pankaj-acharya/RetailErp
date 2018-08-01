using System;
using System.Collections.Generic;
using System.Text;
using ErpModel;

namespace ErpServices
{
    public class CartService:ICartService
    {
        private readonly IProductService _productService;

        #region Ctor

        public CartService(IProductService productService)
        {
            _productService = productService;
        }

        #endregion
        public Cart Add(int productId, int qty, int sessionId)
        {
            
            try
            {
                var cart = new Cart
                {

                };
                var basketProduct = _productService.Get(productId);

                if (basketProduct != null)
                {
                    

                }

                return cart;
            }
            catch (Exception e)
            {
                //TODO: log the error once framework is in place
                Console.WriteLine(e);
                throw;
            }
        }

        public Cart Get(int sessionId)
        {
            throw new NotImplementedException();
        }

        public void ClearCart()
        {
            throw new NotImplementedException();
        }

        public Cart ApplyCoupon()
        {
            throw new NotImplementedException();
        }
    }
}
