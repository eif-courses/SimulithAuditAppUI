using Microsoft.Extensions.Caching.Memory;

namespace SimulithAuditApp.DataAccess
{
  public class MongoCategoryData : ICategoryData
  {
    private readonly IMongoCollection<CategoryModel> _categories;
    private readonly IMemoryCache _cache;
    private const string CacheName = "CategoryData";

    public MongoCategoryData(IDbConnection db, IMemoryCache cache)
    {
      _cache = cache;
      _categories = db.CategoryCollection;
    }
    public async Task<List<CategoryModel>> GetAllCategories()
    {
      
      var output = _cache.Get<List<CategoryModel>>(CacheName);
      if (output is null)
      {
        var results = await _categories.FindAsync(_ => true);
        output = results.ToList();
        
        _cache.Set(CacheName, output, TimeSpan.FromMilliseconds(1));
      }
      return output;
    }
    public Task CreateCategory(CategoryModel category)
    {
      return _categories.InsertOneAsync(category);
    }

    public Task DeleteCategory(string id)
    {
      var deleteFilter = Builders<CategoryModel>.Filter.Eq(category => category.CategoryName, id);
      return  _categories.DeleteOneAsync(deleteFilter);
    }
    
    public async Task UpdateCategory(CategoryModel categoryModel)
    {
      await _categories.ReplaceOneAsync(m => m.Id == categoryModel.Id, categoryModel);
      _cache.Remove(CacheName);
    }
    
    


  }
}
