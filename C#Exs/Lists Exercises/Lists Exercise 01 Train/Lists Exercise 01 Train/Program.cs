using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise_01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());

            string input = string.Empty;
            
            while (input != "end")
            {
                input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add":
                        wagons = CommandAdd(wagons, command);
                        break;
                   
                    default:
                        wagons = CommandFillPassengers(wagons, command, wagonCapacity);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }

        static List<int> CommandAdd(List<int> toAdd, string[] command)
        {
            int wagonToAdd = int.Parse(command[1]);

            toAdd.Add(wagonToAdd);

            return toAdd;
        }

        static List<int> CommandFillPassengers(List<int> toFill, string[] command, int capacity)
        {
            int passengers = int.Parse(command[0]);

            for (int i = 0; i < toFill.Count; i++)
            {
                if (toFill[i] + passengers <= capacity)
                {
                    toFill[i] += passengers;
                    break;
                }
            }

            return toFill;
        }
    }
}
