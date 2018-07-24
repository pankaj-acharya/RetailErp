using System;
using System.Collections.Generic;
using System.Text;
using ErpModel;

namespace ErpServices
{
    public interface ICategoryService
    {
        Category GetCategoryById(int categoryId);
        void CreateCategory();
        void UpdateCategory();
        void DeleteCategory();

    }
}
