using System;
using System.Collections.Generic;
using System.Text;
using ErpModel;

namespace ErpRepository
{
    public interface IProductRepository
    {
        //Create
        Product Create(Product product);

        //Read
        List<Product> Get();
        Product Get(int id);

        //Update
        Product Update(Product product);

        //Delete
        bool Delete(int productId);

        //Helpers
        List<Product> GetProductsByCategory(int categoryId);
    }
}
