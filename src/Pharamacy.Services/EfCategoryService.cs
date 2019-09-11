using System.Collections.Generic;
using System.Linq;
using Pharamacy.Common.GuardToolkit;
using Pharamacy.DataLayer.Context;
using Pharamacy.Entities;
using Pharamacy.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Pharamacy.Services
{
    public class EfCategoryService : ICategoryService
    {
        IUnitOfWork _uow;
        readonly DbSet<Category> _categories;
        public EfCategoryService(IUnitOfWork uow)
        {
            _uow = uow;
            _uow.CheckArgumentIsNull(nameof(_uow));

            _categories = _uow.Set<Category>();
        }

        public void AddNewCategory(Category category)
        {
           _categories.Add(category);
        }

        public IList<Category> GetAllCategories()
        {
            return _categories.ToList();
        }
    }
}
