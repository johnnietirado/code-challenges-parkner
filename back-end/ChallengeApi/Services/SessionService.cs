using System.Collections.Generic;
using ChallengeApi.Models;
using ChallengeApi.Repositories;

namespace ChallengeApi.Services
{

    public interface ISessionService
    {
        List<Session> GetSessions(bool? active);
        Session GetSession(string id);
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
    }
}