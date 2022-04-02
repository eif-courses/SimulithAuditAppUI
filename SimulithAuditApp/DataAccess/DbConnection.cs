using Microsoft.Extensions.Configuration;
namespace SimulithAuditApp.DataAccess
{

  public class DbConnection : IDbConnection
  {
    private readonly IConfiguration _config;
    private readonly IMongoDatabase _db;
    private string _connectionId = "MongoDB";
    public string DbName { get; private set; }
    public string CategoryCollectionName { get; private set; } = "categories";
    public string StatusCollectionName { get; private set; } = "status";
    public string UserCollectionName { get; private set; } = "users";
    public string InternalAuditCollectionName { get; private set; } = "internalAudits";

    public MongoClient Client { get; private set; }

    public IMongoCollection<CategoryModel> CategoryCollection { get; private set; }
    public IMongoCollection<StatusModel> StatusCollection { get; private set; }
    public IMongoCollection<UserModel> UserCollection { get; private set; }
    public IMongoCollection<InternalAuditModel> InternalAuditCollection { get; private set; }


    // Singleton for connection service
    public DbConnection(IConfiguration config)
    {
      _config = config;
      Client = new MongoClient(_config.GetConnectionString(_connectionId));
      DbName = _config["DatabaseName"];
      _db = Client.GetDatabase(DbName);

      // Init Collections for mongo
      CategoryCollection = _db.GetCollection<CategoryModel>(CategoryCollectionName);
      StatusCollection = _db.GetCollection<StatusModel>(StatusCollectionName);
      UserCollection = _db.GetCollection<UserModel>(UserCollectionName);
      InternalAuditCollection = _db.GetCollection<InternalAuditModel>(InternalAuditCollectionName);
    }
  }
}
