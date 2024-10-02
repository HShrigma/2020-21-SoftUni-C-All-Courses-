using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Human : Entity, IBuyer
    {
        public Human(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = GetBirthday(birthday);
            this.Food = 0;
        }

        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 10;
        }

        private string[] GetBirthday(string input)
        {
            return input.Split("/", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
