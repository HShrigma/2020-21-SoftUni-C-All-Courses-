using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            :base(name,age)
        {
            if (age <= 15)
            {
                this.Age = age;
            }
            else
            {
                throw new Exception("A child cannot be older than 15!");
            }
        }
    }
}
