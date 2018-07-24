using System;
using System.Collections.Generic;
using System.Text;
using ErpModel;

namespace ErpRepository
{
    class ProductRepository:IProductRepository
    {
        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
