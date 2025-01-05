
namespace Teste.Entity {
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
        Task<User> Add(User user);
    }

    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetById(int id);
        Task<User> Add(User user);
    }
}