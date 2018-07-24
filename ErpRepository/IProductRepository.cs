using System;
using System.Collections.Generic;
using System.Text;
using ErpModel;

namespace ErpRepository
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        List<Product> GetProductsByCategory(int categoryId);
    }
}
