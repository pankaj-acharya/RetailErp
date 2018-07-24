using System;
using System.Collections.Generic;
using ErpModel;

namespace ErpRepository
{
    public class CategoryRepository :ICategoryRepository
    {
        public List<Category> GetAll()
        {
            return new List<Category>
            {
                new Category{Id = 101,Name = "Men"},
                new Category{Id = 102,Name = "Women"},
                new Category{Id = 103,Name = "Boys"},
                new Category{Id = 104,Name = "Girls"},
                new Category{Id = 105,Name = "Sale"}
            };
        }

        public Category GetById(int id)
        {
            return new Category
            {
                Id = 001,
                Name = "Boots"
            };
        }
    }
}
