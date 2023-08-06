using FigureAreaCalculator.Services.Calculators;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Tests.Services.Calculators
{
    public class CircleAreaCalculatorTests
    {

        [Fact]
        public void CalculateFor_NullCircle_ThrowsArgumentNullException()
        {
            var calculator = new CircleAreaCalculator();

            Circle circle = null;
            
            Assert.Throws<ArgumentNullException>(() => calculator.CalculateFor(circle));
        }

        [Fact]
        public void CalculateFor_Circle_ReturnsCorrectArea()
        {
            var calculator = new CircleAreaCalculator();
            var circle = new Circle(5);
            
            var result = calculator.CalculateFor(circle);
            
            Assert.Equal(78.53981633974483, result);
        }
    }
}

