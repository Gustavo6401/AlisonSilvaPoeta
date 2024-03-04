using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AlisonSilvaIdentityUser.Models.MongoDBCollections.PoesiasDB;

public class Poesia
{
    [BsonElement]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("Titulo")]
    [BsonRepresentation(BsonType.String)]
    public string? Titulo { get; set; }
    [BsonElement("Texto")]
    [BsonRepresentation(BsonType.String)]
    public string? Texto { get; set; }
    [BsonElement("DataPublicacao")]
    [BsonRepresentation(BsonType.DateTime)]
    public DateTime? DataPublicacao { get; set; }
}
