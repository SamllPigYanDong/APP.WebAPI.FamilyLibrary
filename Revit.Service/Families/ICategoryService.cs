using Revit.Shared.Entity.Family;

namespace Revit.Service.Families
{
    public interface ICategoryService
    {
        Task<CategoryDto> AddCategory( CategoryCreateDto createMessages);
        Task<IEnumerable<CategoryDto>> GetCategories();
        Task<int> DeleteCategory(long categoryId);
    }
}