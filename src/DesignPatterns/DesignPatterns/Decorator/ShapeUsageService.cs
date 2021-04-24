using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class ShapeUsageService : IShapeUsageService
    {
        IList<KeyValuePair<DateTime, decimal>> _areaCalculations;

        public ShapeUsageService()
        {
            _areaCalculations = new List<KeyValuePair<DateTime, decimal>>();
        }

        public void AreaCalculated(DateTime timeStamp, decimal calculatedArea)
        {
            _areaCalculations.Add(new KeyValuePair<DateTime, decimal>(timeStamp, calculatedArea));
        }

        public decimal GetCumulativeCalculatedArea()
        {
            return _areaCalculations.Sum(ac => ac.Value);
        }
    }
}
