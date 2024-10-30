using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Dtos;

public class CategoryDto : IDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
}
public class CategoryCreateDto : IDto
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
}
public class CategoryUpdateDto : IDto
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
}
public class CategoryListDto : IDto
{
    public List<CategoryDto> Items { get; set; } = [];
}
