using System.Collections.Generic;
using ChallengeApi.Models;
using ChallengeApi.Repositories;

namespace ChallengeApi.Services
{

    public interface IUserService
    {
        List<User> GetUsers();
        User GetUser(string id);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _users;

        public UserService(IUserRepository users)
        {
            _users = users;
        }

        public List<User> GetUsers() => _users.GetUsers();

        public User GetUser(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}