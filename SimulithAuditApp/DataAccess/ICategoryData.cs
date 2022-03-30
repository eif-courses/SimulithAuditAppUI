
namespace SimulithAuditApp.DataAccess
{
  public interface ICategoryData
  {
    Task CreateCategory(CategoryModel category);
    Task DeleteCategory(string id);
    Task<List<CategoryModel>> GetAllCategories();
  }
}