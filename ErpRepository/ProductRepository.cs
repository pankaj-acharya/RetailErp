using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ErpModel;

namespace ErpRepository
{
    public class ProductRepository:IProductRepository
    {
        #region Test StubData
        //Remove once DB layer is implemented to retrieve  actual data
        readonly List<Product> _testProducts =new List<Product>
        {
            //Mens 

            //Mens>Jackets
            new Product{Id = 201,Name = "Quilted Gear Jacket",Price=50.00,IsActive = true},
            new Product{Id = 202,Name = "Lightweight Zip Jacket",Price=51.00,IsActive = true},
            new Product{Id = 203,Name = " Leather Biker Jacket",Price=52.00,IsActive = true},
            new Product{Id = 204,Name = "Hooded Tape Jacket",Price=53.00,IsActive = true},
            new Product{Id = 205,Name = "Textured Baseball Jacket",Price=54.00,IsActive = true},

            //Mens > Trousers
            new Product{Id = 206,Name = "Quilted Gear Trouser",Price=60.00,IsActive = true},
            new Product{Id = 207,Name = "Lightweight Zip Trouser",Price=61.00,IsActive = true},
            new Product{Id = 208,Name = " Leather Biker Trouser",Price=62.00,IsActive = true},
            new Product{Id = 209,Name = "Hooded Tape Trouser",Price=63.00,IsActive = true},
            new Product{Id = 210,Name = "Textured Baseball Trouser",Price=64.00,IsActive = true},

            //Womens

            //Womens >Skirt
            new Product{Id = 301,Name = "Quilted Gear Skirt",Price=70.00,IsActive = true},
            new Product{Id = 302,Name = "Lightweight Zip Skirt",Price=71.00,IsActive = true},
            new Product{Id = 303,Name = " Leather Biker Skirt",Price=72.00,IsActive = true},
            new Product{Id = 304,Name = "Hooded Tape Skirt",Price=73.00,IsActive = true},
            new Product{Id = 305,Name = "Textured Baseball Skirt",Price=74.00,IsActive = true},

            //WOmens > Dress 
            new Product{Id = 306,Name = "Quilted Gear Dress",Price=80.00,IsActive = true},
            new Product{Id = 307,Name = "Lightweight Zip Dress",Price=81.00,IsActive = true},
            new Product{Id = 308,Name = " Leather Biker Dress",Price=82.00,IsActive = true},
            new Product{Id = 309,Name = "Hooded Tape Dress",Price=83.00,IsActive = true},
            new Product{Id = 310,Name = "Textured Baseball Dress",Price=84.00,IsActive = true}
        };
        #endregion

        #region Create

        public Product Create(Product product)
        {
            //TODO : implement this once DB is in place
            return _testProducts.FirstOrDefault();
        }
        #endregion

        #region Read

        public List<Product> Get()
        {
            return _testProducts.Where(p=>p.IsActive).ToList();
        }
        public Product Get(int id) => _testProducts.Find(p => p.Id == id && p.IsActive);
        #endregion

        #region Update

        public Product Update(Product product)
        {
            //TODO :should we do validation at service level or repository level ??
            //read the DB object
            Product currentProduct = _testProducts.Find(p => p.Id == product.Id);

            //Update values
            currentProduct.Name = product.Name;
            currentProduct.Price = product.Price;
            currentProduct.IsActive = product.IsActive;

            //TODO:DbUpdate
            //How to handle different error scenarios??

            //Return the updated value
            return currentProduct;
        }
        #endregion

        #region Delete
        public bool Delete(int id)
        {
            //read the DB object
            Product currentProduct = _testProducts.Find(p => p.Id == id);

            if (currentProduct != null)
            {
                currentProduct.IsActive = false;
                //TODO:Update the DB i.e mark IsActive flag as false
                return true;
            }
                
            return false;
        }
        #endregion

        #region Helpers
        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _testProducts.Where(p => p.IsActive).ToList();
        }
        #endregion

    }
}
