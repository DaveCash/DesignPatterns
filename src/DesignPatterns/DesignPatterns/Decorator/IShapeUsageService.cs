using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public interface IShapeUsageService
    {
        decimal GetCumulativeCalculatedArea();

        void AreaCalculated(DateTime timestamp, decimal calculatedArea);
    }
}
