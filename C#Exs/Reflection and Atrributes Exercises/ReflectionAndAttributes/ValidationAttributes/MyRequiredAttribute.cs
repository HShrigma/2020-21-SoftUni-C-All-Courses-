using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ValidationAttributes
{
    class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            return obj != null;
        }
    }
}
