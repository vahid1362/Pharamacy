using Microsoft.EntityFrameworkCore;
using Pharamacy.Common.GuardToolkit;
using Pharamacy.DataLayer.Context;
using Pharamacy.Entities.Stock;
using Pharamacy.Services.Contracts.Stock;
using Pharamacy.ViewModels;
using Pharamacy.ViewModels.Stock;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Pharamacy.Services.Stock
{
    public class ShelfService : IShelfService
    {
        #region Feild
        IUnitOfWork _uow;

        private readonly DbSet<Shelf> _shelves;

        #endregion

        #region Ctor
        public ShelfService(IUnitOfWork uow)
        {
            _uow = uow;
            _uow.CheckArgumentIsNull(nameof(_uow));
            _shelves = _uow.Set<Shelf>();
        }
        #endregion


        public Task<AddOrUpdateResultViewModel> AddOrUpdateShelf(AddorUpdateShelfViewModel model)
        {
            model.CheckArgumentIsNull(nameof(model));
            if (model.Id == Guid.Empty)
            {
                return AddShelf(model);
            }
            return EditShelf(model);
        }

        private async Task<AddOrUpdateResultViewModel> AddShelf(AddorUpdateShelfViewModel model)
        {
         
            var result = new AddOrUpdateResultViewModel();
            if (IsShelfNumberDuplicated(model.Number))
            {

                result.IsSuccess = false;
                result.Messgae = Messages.ShelfNumberIsDuplicated;

                return result;
            }
            _shelves.Add(new Shelf()
            {
                Name = model.Name,
                Number = model.Number
            });
            await _uow.SaveChangesAsync();

            result.IsSuccess = true;
            result.Messgae = Messages.OperationIsSuccessFull;

            return result;
        }

        private async Task<AddOrUpdateResultViewModel> EditShelf(AddorUpdateShelfViewModel model)
        {
            var result = new AddOrUpdateResultViewModel();
            var shelf =await _shelves.FirstOrDefaultAsync(x => x.Id == model.Id);
            if(shelf==null)
            {
                result.IsSuccess = true;
                result.Messgae = Messages.shelfNotFound;
             return result;
            }

            if(shelf.Number!=model.Number)
            {
                //در صورتی که شماره قفسه تغییر کرده باشد تکراری بودن  شماره قفسه چک  شود
                if (IsShelfNumberDuplicated(model.Number))
                {

                    result.IsSuccess = false;
                    result.Messgae = Messages.ShelfNumberIsDuplicated;

                    return result;
                }
            }

            shelf.Number = model.Number;
            shelf.Name = model.Name;
            await _uow.SaveChangesAsync();
            return result;
            
            


        }


        private bool IsShelfNumberDuplicated(int number) => _shelves.Any(x => x.Number == number);
    }
}
