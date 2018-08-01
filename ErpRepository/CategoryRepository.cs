using System;
using System.Collections.Generic;
using System.Linq;
using ErpModel;

namespace ErpRepository
{
    public class CategoryRepository :ICategoryRepository
    {
        #region Test StubData
        //Remove once DB layer is implemented to retrieve  actual data
        static List<Product> _productListM = new List<Product>
        {
            new Product {Id = 201, Name = "Quilted Gear Jacket", Price = 50.00, IsActive = true},
            new Product {Id = 202, Name = "Lightweight Zip Jacket", Price = 51.00, IsActive = true},
            new Product {Id = 203, Name = " Leather Biker Jacket", Price = 52.00, IsActive = true},
            new Product {Id = 204, Name = "Hooded Tape Jacket", Price = 53.00, IsActive = true},
            new Product {Id = 205, Name = "Textured Baseball Jacket", Price = 54.00, IsActive = true},
        };

        static List<Product> _productListW = new List<Product>
        {
            new Product{Id = 301,Name = "Quilted Gear Skirt",Price=70.00,IsActive = true},
            new Product{Id = 302,Name = "Lightweight Zip Skirt",Price=71.00,IsActive = true},
            new Product{Id = 303,Name = " Leather Biker Skirt",Price=72.00,IsActive = true},
            new Product{Id = 304,Name = "Hooded Tape Skirt",Price=73.00,IsActive = true},
            new Product{Id = 305,Name = "Textured Baseball Skirt",Price=74.00,IsActive = true}
        };

        private List<Category> _testCategoryList = new List<Category>
        {
            new Category{Id = 101,Name = "Men",IsActive = true,Products = _productListM},
            new Category{Id = 102,Name = "Women",IsActive = true,Products = _productListW},
            new Category{Id = 103,Name = "Boys",IsActive = true},
            new Category{Id = 104,Name = "Girls",IsActive = true},
            new Category{Id = 105,Name = "Sale",IsActive = true}
        };
        #endregion

        #region Create
        public Category Create(Category category)
        {
            return _testCategoryList.FirstOrDefault();
        }

        #endregion

        #region Read
        public List<Category> Get()
        {
            return _testCategoryList.Where(c => c.IsActive).ToList();
        }

        public Category Get(int id)
        {
            return _testCategoryList.Find(c => c.Id == id && c.IsActive);
        }

        #endregion

        #region Update
        public Category Update(Category category)
        {
            //TODO :should we do validation at service level or repository level ??
            //read the DB object
            Category currentCategory = _testCategoryList.Find(c => c.Id == category.Id);

            //Update values
            currentCategory.Name = category.Name;
            currentCategory.IsActive = category.IsActive;

            //TODO:DbUpdate
            //How to handle different error scenarios??

            //Return the updated value
            return currentCategory;
        }
        #endregion

        #region Delete

        public bool Delete(int id)
        {
            //read the DB object
            Category currentCategory = _testCategoryList.Find(c => c.Id == id);

            if (currentCategory != null)
            {
                currentCategory.IsActive = false;
                //TODO:Update the DB i.e mark IsActive flag as false
                return true;
            }

            return false;
        }
        #endregion

    }
}
