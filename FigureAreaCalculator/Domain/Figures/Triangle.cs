namespace FigureAreaCalculator.Figures
{
    public class Triangle : Shape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0) throw new ArgumentNullException(nameof(sideA));
            if (sideB <= 0) throw new ArgumentNullException(nameof(sideB));
            if (sideC <= 0) throw new ArgumentNullException(nameof(sideC));

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Incorrect triangle sides values");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public bool IsRight
        {
            get
            {
                return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2);
            }
        }
    }
}