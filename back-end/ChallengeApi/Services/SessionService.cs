using System.Collections.Generic;
using ChallengeApi.Models;
using ChallengeApi.Repositories;
using MongoDB.Driver.Linq;

namespace ChallengeApi.Services
{

    public interface ISessionService
    {
        List<Session> GetSessions(bool? active);
        Session GetSession(string id);
        List<SessionReportDto> GetReport(string lotId = null);
    }

    public class SessionService : ISessionService
    {
        private readonly ISessionRepository _sessions;

        public SessionService(ISessionRepository sessions)
        {
            _sessions = sessions;
        }

        public List<Session> GetSessions(bool? active) => _sessions.GetSessions(active);

        public Session GetSession(string id)
        {
            return _sessions.GetSession(id);
        }

        public List<SessionReportDto> GetReport(string lotId = null)
        {
            var filter = MongoDB.Driver.Builders<Session>.Filter.Empty;
            if (!string.IsNullOrEmpty(lotId))
            {
                filter &= MongoDB.Driver.Builders<Session>.Filter.Eq(s => s.LotId, lotId);
            }

            var query = from s in _sessions.AsQueryable()
                        group 
        }
    }
}