using RealEstate.Models.DTOs;
using RealEstate.Models.DTOs.ProductDTOs;

namespace RealEstate.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoriesAsync();
    }
}
