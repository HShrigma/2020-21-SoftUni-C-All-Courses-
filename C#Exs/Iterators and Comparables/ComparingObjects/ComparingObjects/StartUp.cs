using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(command));
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            int matches = 0;
            int unmatched = 0;

            foreach (var item in people)
            {
                if (item.Matches(people[index]))
                {
                    matches++;
                }
                else
                {
                    unmatched++;
                }
            }

            if (matches <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {unmatched} {people.Count}");
            }
        }
    }
}
