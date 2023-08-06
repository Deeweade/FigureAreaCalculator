using FigureAreaCalculator.Common.Interfaces.Calculators;

namespace FigureAreaCalculator.Common.Interfaces
{
    public interface ICalculatorsFactory
    {
        ICircleAreaCalculator GetCircleAreaCalculator();
        ITriangleAreaCalculator GetTriangleAreaCalculator();
    }
}