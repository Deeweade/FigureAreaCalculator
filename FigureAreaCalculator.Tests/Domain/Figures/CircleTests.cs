using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Tests.Domain.Figures
{
    public class CircleTests
    {
        [Fact]
        public void Circle_RadiusToZero_ThrowsArgumentNullException()
        {
            double radius = 0;

            Assert.Throws<ArgumentNullException>(() => new Circle(radius));
        }

        [Fact]
        public void Circle_RadiusLessThanZero_ThrowsArgumentNullException()
        {
            double radius = -1;

            Assert.Throws<ArgumentNullException>(() => new Circle(radius));
        }

        [Fact]
        public void Circle_CreatesCircle_WhenRadiusIsValid()
        {
            double radius = 5;

            var circle = new Circle(radius);

            Assert.NotNull(circle);
        }
    }
}

