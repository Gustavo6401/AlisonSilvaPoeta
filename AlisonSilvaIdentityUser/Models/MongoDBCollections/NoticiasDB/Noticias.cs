using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AlisonSilvaIdentityUser.Models.MongoDBCollections.NoticiasDB;

public class Noticias
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("Manchete")]
    [BsonRepresentation(BsonType.String)]
    public string? Manchete { get; set; }
    [BsonElement("Link")]
    [BsonRepresentation(BsonType.String)]
    public string? Link { get; set; }
    [BsonElement("DataNoticia")]
    [BsonRepresentation(BsonType.DateTime)]
    public DateTime? DataNoticia { get; set; }
    [BsonElement("Descricao")]
    [BsonRepresentation(BsonType.String)]
    public string? Descricao { get; set; }
}
