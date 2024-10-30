using Core.Persistence.Repositories;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistance.Repositories.Abstraction
{
    public interface IProductRepository : IRepositoryAsync<Product>
    {
    }
}
