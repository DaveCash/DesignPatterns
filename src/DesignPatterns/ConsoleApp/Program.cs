using DesignPatterns.Decorator;
using DesignPatterns.Decorator.Decorators;
using System;

namespace ConsoleApp
{
    class Program
    {
        private static ShapeUsageService _usageService = new ShapeUsageService();

        static void Main(string[] args)
        {
            IShape square = new Square(5);
            var decoratedSquare = AddDecorators(square);

            DumpShape(square);
            DumpShape(decoratedSquare);

            var circle = new Circle(3.5M);
            var decoratedCircle = AddDecorators(circle);

            DumpShape(circle);
            DumpShape(decoratedCircle);

            Console.WriteLine($"Cumulative calculated area of decorated shapes: {_usageService.GetCumulativeCalculatedArea()}");

            Console.ReadLine();
        }

        static IShape AddDecorators(IShape shape)
        {
            IShape decorated = new ConsoleLoggingShapeDecorator(shape);
            decorated = new UsageRecordingShapeDecorator(decorated, _usageService);

            return decorated;
        }

        static void DumpShape(IShape shape)
        {
            Console.WriteLine("_____________________________");
            shape.Draw();
            Console.WriteLine($"Area {shape.GetArea()}");
            Console.WriteLine($"Circumference {shape.GetCircumference()}");
            Console.WriteLine("_____________________________");
        }
    }
}
