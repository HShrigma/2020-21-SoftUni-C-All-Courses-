using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise_02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> toManipulate = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

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
                    case "Insert":

                        toManipulate = CommandInsert(toManipulate, command);

                        break;

                    case "Delete":

                        toManipulate = CommandDelete(toManipulate, command);

                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", toManipulate));
        }

        static List<int> CommandInsert(List<int> toInsert, string[] command)
        {
            int element = int.Parse(command[1]);

            int index = int.Parse(command[2]);

            toInsert.Insert(index, element);

            return toInsert;
        }

        static List<int> CommandDelete(List<int> toDelete, string[] command)
        {
            int element = int.Parse(command[1]);

            for (int i = 0; i < toDelete.Count; i++)
            {
                if (IsElement(element, toDelete[i]) == true)
                {
                    toDelete.Remove(toDelete[i]);
                }
            }

            return toDelete;
        }

        static bool IsElement(int element, int checkElement)
        {
            if (element == checkElement)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
