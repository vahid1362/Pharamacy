﻿using System.Collections.Generic;
using Pharamacy.Entities.AuditableEntity;

namespace Pharamacy.Entities
{
    public class Category : IAuditableEntity
    {
        public int Id { get; set; }

        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}