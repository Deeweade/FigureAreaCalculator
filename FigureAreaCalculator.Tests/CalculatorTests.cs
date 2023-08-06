using FigureAreaCalculator.Common.Interfaces;
using FigureAreaCalculator.Common.Interfaces.Calculators;
using FigureAreaCalculator.Domain.Exceptions;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculateArea_NullShape_ThrowsArgumentNullException()
        {
            var calculator = new Calculator();

            Assert.Throws<ArgumentNullException>(() => calculator.CalculateArea(null));
        }

        [Fact]
        public void CalculateArea_Circle_ReturnsCorrectArea()
        {
            var calculator = new Calculator();
            var circle = new Circle(5);

            var mockCircleAreaCalculator = new Mock<ICircleAreaCalculator>();
            mockCircleAreaCalculator.Setup(x => x.CalculateFor(circle)).Returns(78.53981633974483);

            var mockCalculatorsFactory = new Mock<ICalculatorsFactory>();
            mockCalculatorsFactory.Setup(x => x.GetCircleAreaCalculator()).Returns(mockCircleAreaCalculator.Object);

            calculator = new Calculator(mockCalculatorsFactory.Object);

            var result = calculator.CalculateArea(circle);
            
            Assert.Equal(78.53981633974483, result);
        }

        [Fact]
        public void CalculateArea_Triangle_ReturnsCorrectArea()
        {
            var calculator = new Calculator();
            var triangle = new Triangle(3, 4, 5);

            var mockTriangleAreaCalculator = new Mock<ITriangleAreaCalculator>();
            mockTriangleAreaCalculator.Setup(x => x.CalculateFor(triangle)).Returns(6);

            var mockCalculatorsFactory = new Mock<ICalculatorsFactory>();
            mockCalculatorsFactory.Setup(x => x.GetTriangleAreaCalculator()).Returns(mockTriangleAreaCalculator.Object);
            calculator = new Calculator(mockCalculatorsFactory.Object);
            
            var result = calculator.CalculateArea(triangle);
            
            Assert.Equal(6, result);
        }

        [Fact]
        public void CalculateArea_UnsupportedShapeType_ThrowsUnsupportedShapeTypeException()
        {
            var calculator = new Calculator();
            var customShape = new CustomShape();

            Assert.Throws<UnsupportedShapeTypeException>(() => calculator.CalculateArea(customShape));
        }

        public class CustomShape : Shape
        {
        }
    }
}