using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Human : Entity
    {
        private int age;
        public Human(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = GetBirthday(birthday);
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        private string[] GetBirthday(string input)
        {
            return input.Split("/", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
