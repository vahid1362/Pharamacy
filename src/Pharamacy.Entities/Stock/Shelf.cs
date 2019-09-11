using Pharamacy.Entities.AuditableEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pharamacy.Entities.Stock
{
  public    class Shelf: IAuditableEntity
    {
        public Shelf()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        public int  Number { get; set; }

        
        public string  Name { get; set; }

      


    }
}
