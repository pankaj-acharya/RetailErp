using System;
using System.Collections.Generic;
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

        #region Create
        public Category Create(Category category)
        {
            return _categoryRepository.Create(category);
        }
        #endregion

        #region Read
        public List<Category> Get()
        {
            return _categoryRepository.Get();
        }

        public Category Get(int id)
        {
            return _categoryRepository.Get(id);
        }
        #endregion

        #region Update
        public Category Update(Category category)
        {
            return _categoryRepository.Update(category);
        }
        #endregion

        #region Delete
        public bool Delete(int id)
        {
            //Before deleting category need to remove Prod > Category relation
            //and mark the category as deleted i.e soft delete 
            return _categoryRepository.Delete(id);
        }
        #endregion
    }
}
