using System;
namespace FigureAreaCalculator.Figures
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentNullException(nameof(radius));

            Radius = radius;
        }

        public double Radius { get; private set; }
    }
}

