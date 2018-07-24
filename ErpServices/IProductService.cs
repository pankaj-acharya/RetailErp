using System;
using System.Collections.Generic;
using System.Text;
using ErpModel;

namespace ErpServices
{
    public interface IProductService
    {
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);

    }
}
