using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChallengeApi.Models
{

    public class SessionReportDto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Date { get; set; }
        public double Total { get; set; }
        public double Cut { get; set; }
    }
    public class Money
    {
        public double Total { get; set; }
        public double Payout { get; set; }

        public Money()
        {

        }
    }
    public class Session
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string LotId { get; set; }
        public string Name { get; set; }
        public Space Spaces { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? Entry { get; set; }
        public DateTime? Exit { get; set; }
        public int Duration { get; set; }

        public Money Money { get; set; } = new Money();

        public Session()
        {

        }
    }
}