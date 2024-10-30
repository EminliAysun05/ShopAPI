using Core.Persistence.Repositories;
using Shop.Domain.Entities;
using Shop.Persistance.Context;
using Shop.Persistance.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistance.Repositories.Implementations
{
    public class ProductRepository : EfRepositoryBase<Product, AppDbContext>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
