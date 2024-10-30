using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CategoryId { get; set; }
    }
     public class ProductCreateDto
    {
      
        public required string Name { get; set; }
    }
    public class ProductUpdateDto
    {
        
        public string? Name { get; set; }
    }
    public class ProductListDto
    {
        public List<ProductDto> Items { get; set; } = [];
    }


}
