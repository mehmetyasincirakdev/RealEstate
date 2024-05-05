using RealEstate.Models.DTOs.CategoryDTOs;

namespace RealEstate.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategoryAsync(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto categoryDto);
        Task<GetByCategoryIdDto> GetByCategory(int id);
    }
}
