using System.Collections.Generic;
using Pharamacy.Entities;

namespace Pharamacy.Services.Contracts
{
    public interface ICategoryService
    {
        void AddNewCategory(Category category);
        IList<Category> GetAllCategories();
    }
}