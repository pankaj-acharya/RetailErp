using System.Collections.Generic;
using ErpModel;
namespace ErpRepository
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}