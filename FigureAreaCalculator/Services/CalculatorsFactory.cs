using FigureAreaCalculator.Common.Interfaces.Calculators;
using FigureAreaCalculator.Services.Calculators;
using FigureAreaCalculator.Common.Interfaces;

namespace FigureAreaCalculator.Services
{
    public class CalculatorsFactory : ICalculatorsFactory
    {
        public ICircleAreaCalculator GetCircleAreaCalculator()
        {
            return new CircleAreaCalculator();
        }

        public ITriangleAreaCalculator GetTriangleAreaCalculator()
        {
            return new TriangleAreaCalculator();
        }
    }
}