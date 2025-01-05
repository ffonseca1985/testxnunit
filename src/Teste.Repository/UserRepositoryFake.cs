public class UserRepositoryFake
{
    public async Task<IEnumerable<User>> GetAll()
        => await Task.FromResult(Enumerable.Empty<User>());
    
    public Task<User> Add(User user)
        => Task.FromResult(user);
}