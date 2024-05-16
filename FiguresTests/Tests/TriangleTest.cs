using Figures;

namespace FiguresTests.Tests;

public class TriangleTest
{
    [Theory]
    [InlineData(4, 5, 3, 6)]
    [InlineData(40, 50, 30, 600)]
    [InlineData(5, 6, 7, 14.696938456699069)]
    public void Calculate_Area_Triangle(double a, double b, double c, double correctArea)
    {
        // Arrange
        var circle = new Triangle(a, b, c);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.Equal(area, correctArea);
    }

    [Theory]
    [InlineData(4, 3, 5, true)]
    [InlineData(4, 3, 6, false)]
    [InlineData(0.6, 0.8, 1, true)]
    public void Determine_Than_Triangle_Is_Rectangular(double a, double b, double c, bool isRectangular)
    {
        // Arrange
        var circle = new Triangle(a, b, c);

        // Act
        bool area = circle.IsTriangleRectangular();

        // Assert
        Assert.Equal(area, isRectangular);
    }
}