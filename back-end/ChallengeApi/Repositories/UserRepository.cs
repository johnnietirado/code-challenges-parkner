using System.Collections.Generic;
using ChallengeApi.Models;
using MongoDB.Driver;

namespace ChallengeApi.Repositories
{

    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(string id);
    }

    public class UserRepository : IUserRepository
    {
        private IMongoCollection<User> _users;
        public UserRepository(IRepository repository)
        {
            _users = repository.GetDatabase().GetCollection<User>("users");
        }

        public List<User> GetUsers()
        {
            return _users.Find(Builders<User>.Filter.Empty).ToList();
        }

        public User GetUser(string id)
        {
            throw new System.NotImplementedException();
        }


    }
}