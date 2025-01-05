using FluentAssertions;
using Teste.Bussiness;
using Teste.Entity;
using Teste.Repository;

namespace Teste.test;

public class UserServiceTests
{
    [Fact]
    public async Task GetUsers_ShouldBeEmpty_WhenNoUserExist()
    {
        // Arrange
        IUserRepository repository = new UserRepository();
        IUserService _sut = new UserService(repository);

        // Act
        var result = await _sut.GetUsers();

        // Assert
        result.Should().BeEmpty();
    }
}
