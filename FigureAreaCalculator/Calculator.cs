using FigureAreaCalculator.Domain.Exceptions;
using FigureAreaCalculator.Common.Interfaces;
using FigureAreaCalculator.Services;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator
{
    public class Calculator
    {
        private readonly ICalculatorsFactory _factory;

        public Calculator()
        {
            _factory = new CalculatorsFactory();
        }

        public Calculator(ICalculatorsFactory factory)
        {
            _factory = factory;
        }

        public double CalculateArea(Shape shape)
        {
            if (shape is null) throw new ArgumentNullException(nameof(shape));

            switch (shape)
            {
                case Triangle:
                    return GetTriangleArea((Triangle)shape);
                case Circle:
                    return GetCircleArea((Circle)shape);
                default:
                    throw new UnsupportedShapeTypeException();
            }
        }

        private double GetCircleArea(Circle circle)
        {
            if (circle is null) throw new ArgumentNullException(nameof(circle));

            var circleAreaCalculator = _factory.GetCircleAreaCalculator();

            var area = circleAreaCalculator.CalculateFor(circle);

            return area;
        }

        private double GetTriangleArea(Triangle triangle)
        {
            if (triangle is null) throw new ArgumentNullException(nameof(triangle));

            var triangleAreaCalculator = _factory.GetTriangleAreaCalculator();

            var area = triangleAreaCalculator.CalculateFor(triangle);

            return area;
        }
    }
}

