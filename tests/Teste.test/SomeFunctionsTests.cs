using FluentAssertions;
using Teste.Bussiness;

public class SomeFunctionsTests
{
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(2, 2, 4)]
    [InlineData(1, 2, 3)]
    [InlineData(10, 10, 20)]
    public void Sum_ShouldSumTwoValues_WhenInvoked(int a, int b, int expectedResult)
    {
        // Arrange
        SomeFunctions _sut = new SomeFunctions();
    
        // Act
        var result = _sut.Sum(a, b);
    
        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void User_ShouldBeEqual_WhenInvoked()
    {
        // Arrange
        User _sut = new User
        {
            Id = 1,
            Name = "João da Silva"
        };
    
        User user = new User
        {
            Id = 1,
            Name = "João da Silva"
        };
    
        // Act
    
        // Assert
        _sut.Should().BeEquivalentTo(user);
    }

    [Fact]
    public void User_ShouldBeValid_WhenInvoked()
    {
        // Arrange
        User _sut = new User
        {
            Id = 1,
            Name = "João da Silva"
        };
    
        // Act
    
        // Assert
        _sut.Id.Should().BeGreaterThan(0);
        _sut.Name.Should().NotBeEmpty().And.Contain("João");
    }
}