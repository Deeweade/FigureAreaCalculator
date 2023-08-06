using FigureAreaCalculator.Common.Interfaces.Calculators;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Services.Calculators
{
    public class CircleAreaCalculator : ICircleAreaCalculator
    {
        public double CalculateFor(Circle circle)
        {
            if (circle is null) throw new ArgumentNullException(nameof(circle));

            return Math.PI * circle.Radius * circle.Radius;
        }
    }
}