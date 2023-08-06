using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Common.Interfaces.Calculators
{
    public interface ITriangleAreaCalculator : IAreaCalculator
    {
        double CalculateFor(Triangle triangle);
    }
}

