using System.Collections.Generic;
using ChallengeApi.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ChallengeApi.Repositories
{

    public interface ISessionRepository
    {
        List<Session> GetSessions(bool? active);
        Session GetSession(string id);
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
            if(active.HasValue && active.Value){
                filter &= Builders<Session>.Filter.Eq("Exit", BsonNull.Value);
            }
            return _sessions.Find(filter).ToList();
        }

        public Session GetSession(string id)
        {
            return _sessions.Find(session => session.Id == id).FirstOrDefault();
        }
    }
}