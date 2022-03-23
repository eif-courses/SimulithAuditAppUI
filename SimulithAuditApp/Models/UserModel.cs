using MongoDB.Bson.Serialization.IdGenerators;

namespace SimulithAuditApp.Models
{
  public class UserModel
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string ObjectIdentifier { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public string EmailAddress { get; set; }
    public List<BaseInternalAuditModel> InternalAuditModels { get; set; } = new();
    public List<BaseInternalAuditModel> VotedOnAuditModels { get; set; } = new();

  }
}
