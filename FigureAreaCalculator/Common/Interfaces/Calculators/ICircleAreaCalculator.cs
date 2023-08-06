using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Common.Interfaces.Calculators
{
    public interface ICircleAreaCalculator : IAreaCalculator
    {
        double CalculateFor(Circle circle);
    }
}

