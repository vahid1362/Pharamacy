using Microsoft.EntityFrameworkCore;
using Pharamacy.Entities.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pharamacy.DataLayer.Mappings
{
  public static  class StockMapping
    {
        public static void AddStockMapping(this ModelBuilder builder)
        {
            builder.Entity<Shelf>().ToTable("Shelves");
            builder.Entity<Shelf>().Property(x => x.Name).HasMaxLength(200);


        }
    }
}
