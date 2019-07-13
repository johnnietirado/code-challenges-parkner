using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChallengeApi.Models
{

    public class User
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }

        // This field should not be returned to the client
        public string PrivatePasswordHash { get; set; }
    }
}