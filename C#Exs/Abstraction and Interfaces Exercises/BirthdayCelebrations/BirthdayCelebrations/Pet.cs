using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    class Pet : Entity
    {
        private string[] birthday;
        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = GetBirthday(birthday);
        }
        private string[] GetBirthday(string input)
        {
            return input.Split("/", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
