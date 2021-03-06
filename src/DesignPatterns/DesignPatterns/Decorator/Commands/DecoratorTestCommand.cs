using DesignPatterns.Decorator.Decorators;
using System;

namespace DesignPatterns.Decorator.Commands
{
    public class DecoratorTestCommand
    {
        private static ShapeUsageService _usageService = new ShapeUsageService();

        public static void Run()
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
