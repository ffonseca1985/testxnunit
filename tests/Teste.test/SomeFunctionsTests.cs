using FluentAssertions;
using Teste.Bussiness;
using Teste.Entity;

public class SomeFunctionsTests
{
    [Fact]
    public void UserList_ShouldNotBeEmpty_WhenHaveElements()
    {
        // Arrange
        User user = new User
        {
            Id = 1,
            Name = "João da Silva"
        };
        var _sut = new List<User> { user };

        // Act

        // Assert
        _sut.Should().NotBeEmpty();
        _sut.Should().HaveCount(1);
        // _sut.Should().HaveCountGreaterThan(1);
        // _sut.Should().HaveCountLessThan(1);
    }

    [Fact]
    public void UserList_ShouldContainUser_WhenListIsNotEmpty()
    {
        // Arrange
        User user = new User
        {
            Id = 1,
            Name = "João da Silva"
        };
        var _sut = new List<User> { user };

        // Act

        // Assert
        _sut.Should().NotBeEmpty();
        _sut.Should().Contain(user);
    }

    [Fact]
    public void UserList_ShouldContainUser_WhenListIsNotEmptyEquivalent()
    {
        // Arrange
        User userToFind = new User
        {
            Id = 1,
            Name = "João da Silva"
        };
        User user = new User
        {
            Id = 1,
            Name = "João da Silva"
        };
        var _sut = new List<User> { user };

        // Act

        // Assert
        _sut.Should().NotBeEmpty();
        _sut.Should().ContainEquivalentOf(userToFind);
    }

    [Fact]
    public void UserList_ShouldContainUserByName_WhenListIsNotEmpty()
    {
        // Arrange
        User user = new User
        {
            Id = 1,
            Name = "João da Silva"
        };
        var _sut = new List<User> { user };
    
        // Act
    
        // Assert
        _sut.Should().Contain(x => x.Name.StartsWith("João"));
    }

    [Fact]
    public void Divide_ShouldThrowException_WhenDividedByZero()
    {
        // Arrange
        SomeFunctions _sut = new SomeFunctions();
    
        // Act
        Func<int> result = () => _sut.Divide(1, 0);
    
        // Assert
        result.Should().Throw<DivideByZeroException>();
    }
}