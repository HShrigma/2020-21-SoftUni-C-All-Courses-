using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes;
using System.Reflection;

namespace ValidationAttributes
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.FullName = name;
            this.Age = age;
        }

        [MyRequired]
        public string FullName { get; set; }

        [MyRange(12, 90)]
        public int Age { get; set; }
    }
}
