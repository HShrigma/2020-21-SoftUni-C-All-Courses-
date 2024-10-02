using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Lab_06_List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console
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
                    case "Add":
                        
                        nums = CommandAdd(nums, command[1]);
                        
                        break;
                    
                    case "Remove":

                        nums = CommandRemove(nums, command[1]);
                        
                        break;
                    
                    case "RemoveAt":

                        nums = CommandRemoveAt(nums, command[1]);

                        break;
                    case "Insert":

                        nums = CommandInsert(nums, command[1], command[2]);

                        break;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
        static void CommandContains(List<int> toCheck, string toParse)
        {
            int checkNum = int.Parse(toParse);

            if (toCheck.Contains(checkNum))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static List<int> CommandAdd(List<int> toAdd, string toParse)
        {
            int add = int.Parse(toParse);
            toAdd.Add(add);

            return toAdd;
        }

        static List<int> CommandRemove(List<int> toRemove, string toParse)
        {
            int remove = int.Parse(toParse);
            toRemove.Remove(remove);

            return toRemove;
        }

        static List<int> CommandRemoveAt(List<int> toRemoveAt, string toParse)
        {
            int removeAt = int.Parse(toParse);
            toRemoveAt.RemoveAt(removeAt);

            return toRemoveAt;
        }
        
        static List<int> CommandInsert(List<int> toInsert, string toParseElement, string toParseIndex)
        {
            int insertElement = int.Parse(toParseElement);
            int insertIndex = int.Parse(toParseIndex);

            toInsert.Insert(insertIndex, insertElement);

            return toInsert;
        }
    }
}
