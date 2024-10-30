using Core.Persistence.Repositories;

namespace Shop.Domain.Entities;

public class Category : Entity
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
}
