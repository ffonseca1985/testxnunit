
using Teste.Entity;

namespace Teste.Repository
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _users = new List<User>();

        public async Task<User> Add(User user)
        {
            _users.Add(user);
            return await Task.FromResult(user);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await Task.FromResult(_users);
        }

        public Task<User> GetById(int id)
        {
            return Task.FromResult(_users.First(x => x.Id == id));
        }
    }
}