using Teste.Entity;
using Teste.Repository;

namespace Teste.Bussiness
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _repository.GetAll();
        }

        public async Task<User> GetById(int id)
        {
            try
            {
                return await _repository.GetById(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<User> Add(User user)
        {
            return await _repository.Add(user);
        }
    }
}