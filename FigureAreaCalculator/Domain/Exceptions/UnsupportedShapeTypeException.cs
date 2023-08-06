using System;
namespace FigureAreaCalculator.Domain.Exceptions
{
    public class UnsupportedShapeTypeException : Exception
    {
        public UnsupportedShapeTypeException() : base("Unsupported Shape type!")
        {
        }
    }
}

