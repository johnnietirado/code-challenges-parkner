using System.Collections.Generic;
using ChallengeApi.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace ChallengeApi.Repositories
{

    public interface ISessionRepository
    {
        List<Session> GetSessions(bool? active);
        Session GetSession(string id);
        List<SessionReportDto> GetReport(string lotId);
    }

    public class SessionRepository : ISessionRepository
    {
        private IMongoCollection<Session> _sessions;
        public SessionRepository(IRepository repository)
        {
            _sessions = repository.GetDatabase().GetCollection<Session>("sessions");
        }

        public List<Session> GetSessions(bool? active)
        {
            var filter = Builders<Session>.Filter.Empty;
            if (active.HasValue && active.Value)
            {
                filter &= Builders<Session>.Filter.Eq("Exit", BsonNull.Value);
            }
            return _sessions.Find(filter).ToList();
        }

        public Session GetSession(string id)
        {
            return _sessions.Find(session => session.Id == id).FirstOrDefault();
        }

        public List<SessionReportDto> GetReport(string lotId)
        {
            var filter = MongoDB.Driver.Builders<Session>.Filter.Empty;
            if (!string.IsNullOrEmpty(lotId))
            {
                filter &= MongoDB.Driver.Builders<Session>.Filter.Eq(s => s.LotId, lotId);
            }

            var pipeline = PipelineDefinition<Session, SessionReportDto>.Create(
                BsonDocument.Parse("{ $match: {}}"),
                BsonDocument.Parse("{ $group: { '_id': { $substr: ['$CreatedAt', 0, 7] }, Total: {$sum: '$Money.Total'}, Payouts: {$sum: '$Money.Payout'}  }}"),
                BsonDocument.Parse("{ $project: {'_id': '$_id', 'Total': '$Total', 'Cut': {$subtract: ['$Total', '$Payouts'] } } }")
            );
            
            return _sessions.Aggregate(pipeline).ToList();
        }
    }
}