using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Dtos;
using Shop.Application.Services.CategoryService;

namespace Shopp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "SuperAdmin,Admin")]

public class CategoryController : ControllerBase
{


    private readonly ICategoryService _categoryManager;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryManager = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetByPage([FromQuery] PageRequest pageRequest)
    {
        var categoryList = await _categoryManager.GetListAsync(index: pageRequest.Index, size: pageRequest.Size);

        return Ok(categoryList);
    }

    [HttpGet("{id?}")]
    public async Task<IActionResult> Get(int? id)
    {
        if (id == null) return NotFound();

        var category = await _categoryManager.GetAsync(id.Value);

        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CategoryCreateDto createDto)
    {
        var createdCategory = await _categoryManager.AddAsync(createDto);

        return Ok(createdCategory);
    }

    [HttpPut("{id?}")]
    public async Task<IActionResult> Put(int? id, [FromBody] CategoryUpdateDto updateDto)
    {
        if (id == null) return NotFound();

        var updatedCategory = await _categoryManager.UpdateAsync(id.Value, updateDto);

        return Ok(updatedCategory);
    }
}


