using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Dtos;
using Shop.Application.Services.CategoryService;
using Shop.Application.Services.ProductService;
using Shop.Domain.Entities;

namespace Shopp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "SuperAdmin,Admin")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productManager;

    public ProductController(IProductService productService)
    {
        _productManager = productService;
    }

    [HttpGet]
    public async Task<IActionResult> GetByPage([FromQuery] PageRequest pageRequest)
    {
        var productList = await _productManager.GetListAsync(index: pageRequest.Index, size: pageRequest.Size);

        return Ok(productList);
    }

    [HttpGet("{id?}")]
    public async Task<IActionResult> Get(int? id)
    {
        if (id == null) return NotFound();

        var product = await _productManager.GetAsync(id.Value);

        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ProductCreateDto createDto)
    {
        var createdProduct = await _productManager.AddAsync(createDto);

        return Ok(createdProduct);
    }

    [HttpPut("{id?}")]
    public async Task<IActionResult> Put(int? id, [FromBody] ProductUpdateDto updateDto)
    {
        if (id == null) return NotFound();

        var updatedProduct = await _productManager.UpdateAsync(id.Value, updateDto);

        return Ok(updatedProduct);
    }
}

