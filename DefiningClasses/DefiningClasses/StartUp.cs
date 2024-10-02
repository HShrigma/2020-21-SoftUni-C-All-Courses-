using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            Family family = new Family();
            
            for (int i = 0; i < len; i++)
            {
                string[] command = Console
                    .ReadLine()
                    .Split();

                Person temp = new Person(command[0], int.Parse(command[1]));
                family.AddMemeber(temp);
            }

            //Console.WriteLine(family.GetOldestMember());

            HashSet<Person> peopleAbove30 = family.GetAllAbove30();

            Console.WriteLine(string.Join(Environment.NewLine,peopleAbove30));
        }
    }
}
