using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(params string[] input)
        {
            Name = input[0];
            Age = int.Parse(input[1]);
            Town = input[2];
        }
        public string Data()
        {
            return $"{this.Name} {this.Age} {this.Town}";
        }

        public bool Matches(Person person)
        {
            if (this.CompareTo(person) == 0)
            {
                return true;
            }
            return false;
        }

        public int CompareTo([AllowNull] Person other)
        {
            return this.Data().CompareTo(other.Data());
        }
    }
}
