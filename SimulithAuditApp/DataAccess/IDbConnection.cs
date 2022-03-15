using MongoDB.Driver;

namespace SimulithAuditApp.DataAccess
{
  public interface IDbConnection
  {
    IMongoCollection<CategoryModel> CategoryCollection { get; }
    string CategoryCollectionName { get; }
    MongoClient Client { get; }
    string DbName { get; }
    IMongoCollection<InternalAuditModel> InternalAuditCollection { get; }
    string InternalAuditCollectionName { get; }
    IMongoCollection<StatusModel> StatusCollection { get; }
    string StatusCollectionName { get; }
    IMongoCollection<UserModel> UserCollection { get; }
    string UserCollectionName { get; }
  }
}