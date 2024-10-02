using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                MyValidationAttribute validationAttribute = (MyValidationAttribute)property
                    .GetCustomAttribute(typeof(MyValidationAttribute),false);

                bool valid = validationAttribute.IsValid(property.GetValue(obj));

                if (!valid)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
