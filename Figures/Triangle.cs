using Figures.Interfaces;

namespace Figures;

public class Triangle(double a, double b, double c) : IFigure
{
    public double CalculateArea()
    {
        var p = GetHalfMeter();
        var area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        return area;
    }

    public double GetHalfMeter() =>
        (a + b + c) / 2;

    public bool IsTriangleRectangular()
    {
        if (a * a + b * b == c * c ||
            a * a + c * c == b * b ||
            b * b + c * c == a * a)
        {
            return true;
        }

        return false;
    }
}