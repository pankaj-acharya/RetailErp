using System;
using System.Collections.Generic;
using System.Text;
using ErpModel;

namespace ErpServices
{
    public interface ICategoryService
    {
        //Create
        Category Create(Category category);

        //Read
        List<Category> Get();
        Category Get(int id);
        
        //Update
        Category Update(Category category);

        //Delete
        bool Delete(int id);

        //Helpers

    }
}
