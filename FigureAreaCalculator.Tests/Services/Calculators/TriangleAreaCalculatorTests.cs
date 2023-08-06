using FigureAreaCalculator.Services.Calculators;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Tests.Services.Calculators
{
    public class TriangleAreaCalculatorTests
    {
        [Fact]
        public void CalculateFor_NullTriangle_ThrowsArgumentNullException()
        {
            var calculator = new TriangleAreaCalculator();

            Triangle triangle = null;

            Assert.Throws<ArgumentNullException>(() => calculator.CalculateFor(triangle));
        }

        [Fact]
        public void CalculateFor_Triangle_ReturnsCorrectArea()
        {
            var calculator = new TriangleAreaCalculator();
            var circle = new Triangle(3, 4, 5);

            var result = calculator.CalculateFor(circle);

            Assert.Equal(6, result);
        }
    }
}

