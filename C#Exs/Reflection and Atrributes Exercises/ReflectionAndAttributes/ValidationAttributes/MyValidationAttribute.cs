using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ValidationAttributes
{
    public abstract class MyValidationAttribute: Attribute
    {
        public abstract bool IsValid(object obj);
    }
}
