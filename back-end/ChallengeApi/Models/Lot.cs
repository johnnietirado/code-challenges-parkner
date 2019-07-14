using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChallengeApi.Models
{

    public class Space
    {
        public int Floor {get; set;}
        public int Number {get; set;}

        public Space(int floor, int number) {
            Floor = floor;
            Number = number;
        }
    }
    public class Lot
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public List<Space> Spaces { get; set; } = new List<Space>();

        public Lot()
        {

        }
    }
}