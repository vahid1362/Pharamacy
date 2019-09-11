using System.Collections.Generic;
using System.Linq;
using Pharamacy.Common.GuardToolkit;
using Pharamacy.DataLayer.Context;
using Pharamacy.Entities;
using Pharamacy.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Pharamacy.Services
{
    public class EfProductService : IProductService
    {
        IUnitOfWork _uow;
        readonly DbSet<Product> _products;
        public EfProductService(IUnitOfWork uow)
        {
            _uow = uow;
            _uow.CheckArgumentIsNull(nameof(_uow));

            _products = _uow.Set<Product>();
        }

        public void AddNewProduct(Product product)
        {
            _products.Add(product);
        }

        public IList<Product> GetAllProducts()
        {
            return _products.Include(x => x.Category).ToList();
        }
    }
}
