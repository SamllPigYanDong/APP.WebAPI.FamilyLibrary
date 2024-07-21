using Revit.Entity.Entity.Dtos.Family;

namespace Revit.Service.Families
{
    public interface ICategoryService
    {
        Task<CategoryDto> AddCategory( CategoryCreateDto createMessages);
        Task<IEnumerable<CategoryDto>> GetCategories();
    }
}