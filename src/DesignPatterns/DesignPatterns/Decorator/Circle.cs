using System;

namespace DesignPatterns.Decorator
{
    public class Circle : IShape
    {
        decimal _radius;

        public Circle(decimal radius)
        {
            _radius = radius > 0 ? radius : throw new ArgumentException($"Argument {nameof(radius)} must be greater than 0");
        }

        public void Draw()
        {
            Console.WriteLine("---DREW CIRCLE---");
        }

        public decimal GetArea()
        {
            return ((decimal) Math.PI) * (_radius * _radius);
        }

        public decimal GetCircumference()
        {
            return 2 * ((decimal)Math.PI) * _radius;
        }
    }
}
