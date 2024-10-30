using Core.Persistence.Repositories;
using Shop.Domain.Entities;

namespace Shop.Persistance.Repositories.Abstraction;

public interface ICategoryRepository : IRepositoryAsync<Category>
{
}
