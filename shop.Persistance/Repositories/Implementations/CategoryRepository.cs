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
    public class CategoryRepository : EfRepositoryBase<Category, AppDbContext>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
