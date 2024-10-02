using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ValidationAttributes
{
    class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.maxValue = maxValue;
            this.minValue = minValue;
        }

        public override bool IsValid(object obj)
        {
            if (!(obj is int))
            {
                throw new ArgumentException("Invalid data type");
            }
            int valueAsInt = (int)obj;
            bool isInRange = valueAsInt >= this.minValue && valueAsInt <= this.maxValue;

            return isInRange;
        }
    }
}
