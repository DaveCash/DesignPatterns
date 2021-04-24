using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Decorators
{
    /* 
     Every time the decorated object's area is calculated, inform the IShapeUsageService
     
     We're only adding functionality to GetArea method calls. Since we have BaseShapeDecorator, we don't need to implement the other IShape methods

    */
    public class UsageRecordingShapeDecorator : BaseShapeDecorator
    {
        IShapeUsageService _usageService;

        public UsageRecordingShapeDecorator(IShape decorated, IShapeUsageService usageService) : base(decorated)
        {
            _usageService = usageService ?? throw new ArgumentNullException((nameof(usageService)));
        }

        public override decimal GetArea()
        {
            var area = _decorated.GetArea();

            _usageService.AreaCalculated(DateTime.UtcNow, area);

            return area;
        }
    }
}
