using System;
using System.Collections.Generic;
using System.Text;
using ErpModel;

namespace ErpServices
{
    public interface IProductService
    {
        //Create
        Product Create(Product product);

        //Read
        List<Product> Get();
        Product Get(int id);

        //Update
        Product Update(Product product);

        //Delete
        bool Delete(int id);

        //Helpers
        //TODO:Should this be abstracted in  newly created ProductCategory in future? 
        List<Product> GetProductsInCategory(int categoryId);
    }
}
