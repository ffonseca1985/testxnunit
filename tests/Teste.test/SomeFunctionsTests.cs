using Teste.Bussiness;

public class SomeFunctionsTests
{
    [Fact]
    public void Sum_ShouldSumTwoValues_WhenInvoked_WithoutInlineData()
    {
        // Arrange
        SomeFunctions _sut = new SomeFunctions();

        // Act
        var result = _sut.Sum(1, 1);

        // Assert
        Assert.Equal(2, result);
    }

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
        Assert.Equal(expectedResult, result);
    }
}