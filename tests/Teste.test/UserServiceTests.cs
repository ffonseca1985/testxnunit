using FluentAssertions;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Teste.Bussiness;
using Teste.Entity;
using Teste.Repository;

namespace Teste.test;

public class UserServiceTests
{
    private readonly IUserRepository _repository;
    private IUserService _sut;

    public UserServiceTests()
    {
        _repository = Substitute.For<IUserRepository>();
        _sut = new UserService(_repository);
    }

    [Fact]
    public async Task GetUsers_ShouldBeEmpty_WhenNoUserExist()
    {
        // Arrange
        _repository.GetAll().Returns(Enumerable.Empty<User>()); 

        // Act
        var result = await _sut.GetUsers();

         // Assert
        result.Should().BeEmpty();
    }

    [Fact]
    public async Task GetUsers_ShouldHaveUser_WhenInvoked()
    {
        // Arrange
        var user = new User
        {
            Id = 1,
            Name = "João da Silva"
        };
        _repository.GetAll().Returns(new User[] { user });
    
        // Act
        var result = await _sut.GetUsers();
    
        // Assert
        result.Should().HaveCount(1);
        result.FirstOrDefault().Should().BeEquivalentTo(user);
    }

    [Fact]
    public async Task Add_ShouldSaveUser_WhenInvoked()
    {
        // Arrange
        var user = new User
        {
            Id = 1,
            Name = "João da Silva"
        };
        var expectedUser = new User
        {
            Id = 1,
            Name = "João da Silva"
        };
        _repository.Add(Arg.Any<User>()).Returns(user);
    
        // Act
        var result = await _sut.Add(user);
    
        // Assert
        result.Should().BeEquivalentTo(expectedUser);
    }
}
