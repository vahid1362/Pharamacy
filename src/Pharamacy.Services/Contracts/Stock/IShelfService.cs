using Pharamacy.ViewModels;
using Pharamacy.ViewModels.Stock;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pharamacy.Services.Contracts.Stock
{
  public  interface IShelfService
    {

     Task<AddOrUpdateResultViewModel> AddOrUpdateShelf(AddorUpdateShelfViewModel model);
    }
}
