using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models.DTOs.CategoryDTOs;
using RealEstate.Repositories.CategoryRepository;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryRepository.GetAllCategoryAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryRepository.CreateCategoryAsync(createCategoryDto);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryRepository.UpdateCategory(updateCategoryDto);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByCategoryId(int id)
        {
            var value = await _categoryRepository.GetByCategory(id);
            return Ok(value);
        }
    }
}
