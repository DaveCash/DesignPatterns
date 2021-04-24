using System;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Square : IShape
    {
        decimal _size;

        public Square(decimal size)
        {
            _size = size > 0 ? size : throw new ArgumentException($"Argument {nameof(size)} must be greater than 0");
        }

        public void Draw()
        {
            Console.WriteLine("---DRAW SQUARE---");
        }

        public decimal GetArea()
        {
            return _size * _size;
        }

        public decimal GetCircumference()
        {
            return _size * 4;
        }
    }
}
