using FigureAreaCalculator.Common.Interfaces.Calculators;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Services.Calculators
{
    public class TriangleAreaCalculator : ITriangleAreaCalculator
    {
        public double CalculateFor(Triangle triangle)
        {
            if (triangle is null) throw new ArgumentNullException(nameof(triangle));

            var semiPerimeter = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - triangle.SideA) *
                (semiPerimeter - triangle.SideB) * (semiPerimeter - triangle.SideC));
        }
    }
}

