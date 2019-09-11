using System.Collections.Generic;
using Pharamacy.Entities;

namespace Pharamacy.Services.Contracts
{
    public interface IProductService
    {
        void AddNewProduct(Product product);
        IList<Product> GetAllProducts();
    }
}