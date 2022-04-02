
namespace SimulithAuditApp.DataAccess
{
  public interface ICategoryData
  {
    Task CreateCategory(CategoryModel category);
    Task DeleteCategory(string id);
    Task UpdateCategory(CategoryModel categoryModel);
    Task<List<CategoryModel>> GetAllCategories();
  }
}