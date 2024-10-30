using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Entities
{
    public class Product : Entity
    {
        public required string Name { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
