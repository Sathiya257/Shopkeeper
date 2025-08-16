namespace ShopKeeper.Models;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Person
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("name")]
    public string? Name { get; set; }

    [BsonElement("age")]
    public int Age { get; set; }

    [BsonElement("gender")]
    public string? Gender { get; set; }
}
