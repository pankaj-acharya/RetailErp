using System;
using System.Collections.Generic;
using System.Text;
using ErpModel;
using ErpRepository;

namespace ErpServices
{
    public class ProductService :IProductService
    {
        private readonly IProductRepository _productRepository;
        #region Ctor
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        #endregion

        #region Create
        public Product Create(Product product)
        {
            return _productRepository.Create(product);
        }
        #endregion

        #region Read
        public List<Product> Get()
        {
            return _productRepository.Get();
        }
        public Product Get(int id)
        {
            return _productRepository.Get(id);
        }
        #endregion

        #region Update
        public Product Update(Product product)
        {
            return _productRepository.Create(product);
        }
        #endregion

        #region Delete
        public bool Delete(int id)
        {
            //Mark the product as deleted i.e soft delete
            return _productRepository.Delete(id);
        }
        #endregion

        #region Helpers
        public List<Product> GetProductsInCategory(int categoryId)
        {
            return _productRepository.GetProductsByCategory(categoryId);
        }
        #endregion
    }
}
