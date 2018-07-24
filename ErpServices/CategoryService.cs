using System;
using ErpModel;
using ErpRepository;

namespace ErpServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        #region Ctor

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        #endregion
        public void CreateCategory()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int categoryId)
        {
          return  _categoryRepository.GetById(categoryId);
        }

        public void UpdateCategory()
        {
            throw new NotImplementedException();
        }
    }
}
