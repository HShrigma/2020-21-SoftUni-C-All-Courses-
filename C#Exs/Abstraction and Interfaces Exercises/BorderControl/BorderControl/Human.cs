using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Human : Entity
    {
        private int age;

        public Human(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
        public int Age
        {
            get { return this.age;}
            set { age = value;}
        }
    }
}
