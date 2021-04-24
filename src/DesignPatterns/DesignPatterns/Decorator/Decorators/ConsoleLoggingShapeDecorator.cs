using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Decorators
{
    // Adds console logging before and after every method call on the decorated object
    public class ConsoleLoggingShapeDecorator : BaseShapeDecorator
    {
        public ConsoleLoggingShapeDecorator(IShape decorated) : base(decorated)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"BEFORE {nameof(Draw)}");

            _decorated.Draw();

            Console.WriteLine($"AFTER {nameof(Draw)}");
        }

        public override decimal GetArea()
        {
            Console.WriteLine($"BEFORE {nameof(GetArea)}");

            var area =  _decorated.GetArea();

            Console.WriteLine($"AFTER {nameof(GetArea)}");

            return area;
        }

        public override decimal GetCircumference()
        {
            Console.WriteLine($"BEFORE {nameof(GetCircumference)}");

            var circ =  _decorated.GetCircumference();

            Console.WriteLine($"AFTER {nameof(GetCircumference)}");

            return circ;
        }
    }
}
