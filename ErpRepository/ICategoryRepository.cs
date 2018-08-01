using System.Collections.Generic;
using ErpModel;
namespace ErpRepository
{
    public interface ICategoryRepository
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