using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Repositories.ProductRepository;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("GetAllProductsWithCategory")]
        public async Task<IActionResult> GetAllProductsWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoriesAsync();
            return Ok(values);
        }

    }
}
