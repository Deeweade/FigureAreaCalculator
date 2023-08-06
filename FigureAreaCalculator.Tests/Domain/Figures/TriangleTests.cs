using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Tests.Domain.Figures
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_ThrowsException_WhenSideAIsZero()
        {
            Assert.Throws<ArgumentNullException>(() => new Triangle(0, 1, 2));
        }

        [Fact]
        public void Triangle_ThrowsException_WhenSideBIsZero()
        {
            Assert.Throws<ArgumentNullException>(() => new Triangle(1, 0, 2));
        }

        [Fact]
        public void Triangle_ThrowsException_WhenSideCIsZero()
        {
            Assert.Throws<ArgumentNullException>(() => new Triangle(1, 2, 0));
        }

        [Fact]
        public void Triangle_ThrowsException_WhenSideAIsNegative()
        {
            Assert.Throws<ArgumentNullException>(() => new Triangle(-1, 1, 2));
        }

        [Fact]
        public void Triangle_ThrowsException_WhenSideBIsNegative()
        {
            Assert.Throws<ArgumentNullException>(() => new Triangle(1, -1, 2));
        }

        [Fact]
        public void Triangle_ThrowsException_WhenSideCIsNegative()
        {
            Assert.Throws<ArgumentNullException>(() => new Triangle(1, 2, -1));
        }

        [Fact]
        public void Triangle_ThrowsException_WhenSidesDoNotSatisfyTriangleInequality()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 4));
        }

        [Fact]
        public void Triangle_CreatesTriangle_WhenSidesAreValid()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.NotNull(triangle);
        }

        [Fact]
        public void Triangle_IsRight_ReturnsTrue_WhenTriangleIsRight()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRight);
        }
    }
}