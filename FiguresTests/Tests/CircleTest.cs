using Figures;

namespace FiguresTests.Tests;

public class CircleTest
{
    [Theory]
    [InlineData(15, 706.85834705770344)]
    [InlineData(20, 1256.6370614359173)]
    [InlineData(34, 3631.6811075498013)]
    public void Calculate_Area_Circle(double radius, double Correctarea)
    {
        // Arrange
        var circle = new Circle(radius);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.Equal(area, Correctarea);
    }
}