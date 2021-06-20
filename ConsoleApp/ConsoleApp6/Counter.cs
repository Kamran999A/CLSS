using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Partial_Classes
{
    public class Counter
    {
        public double MinValue { get; set; }
        public double CurrentValue { get; set; }
        private double _maxValue;
        public double MaxValue
        {
            get { return _maxValue; }
            set
            {
                if (value <= MinValue)
                    throw new ArgumentOutOfRangeException(nameof(_maxValue), "Maximum counter must be more than Minimum counter!");

                _maxValue = value;
            }
        }
        public Counter(in double minValue, in double maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            CurrentValue = minValue;
        }
        public double Increment()
        {
            return (CurrentValue == MaxValue ) ? CurrentValue = MinValue : ++CurrentValue;
        }
    }
}
