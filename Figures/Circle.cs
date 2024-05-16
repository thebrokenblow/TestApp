using Figures.Interfaces;

namespace Figures;

public class Circle(double radius) : IFigure
{
    public double CalculateArea() =>
        Math.PI * radius * radius;
}