using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Lab_7_List_Manipulation_Advanced
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
            bool changesWereMade = false;

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
                    case "Contains":

                        CommandContains(nums, command[1]);

                        break;

                    case "PrintEven":

                        CommandPrintEven(nums);

                        break;

                    case "PrintOdd":
                        
                        CommandPrintOdd(nums);
                        
                        break;

                    case "GetSum":

                        CommandGetSum(nums);

                        break;

                    case "Filter":

                        CommandFilter(nums, command[1], command[2]);

                        break;

                    case "Add":

                        nums = CommandAdd(nums, command[1]);
                        changesWereMade = true;
                        break;

                    case "Remove":

                        nums = CommandRemove(nums, command[1]);
                        changesWereMade = true;
                        break;

                    case "RemoveAt":

                        nums = CommandRemoveAt(nums, command[1]);
                        changesWereMade = true;
                        break;
                    case "Insert":

                        nums = CommandInsert(nums, command[1], command[2]);
                        changesWereMade = true;
                        break;
                }
            }
           
            if (changesWereMade)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }

        static void CommandFilter(List<int> toFilter, string condition, string number)
        {
            int numParsed = int.Parse(number);
            List<int> filtered = new List<int>();
               
            switch (condition)
            {
                case ">":
                   
                    foreach (var item in toFilter)
                    {
                        if (item > numParsed)
                        {
                            filtered.Add(item);
                        }
                    }
                    
                    break;
              
                case "<":
                    
                    foreach (var item in toFilter)
                    {
                        if (item < numParsed)
                        {
                            filtered.Add(item);
                        }
                    }

                    break;
              
                case ">=":

                    foreach (var item in toFilter)
                    {
                        if (item >= numParsed)
                        {
                            filtered.Add(item);
                        }
                    }
                    break;
              
                case "<=":

                    foreach (var item in toFilter)
                    {
                        if (item <= numParsed)
                        {
                            filtered.Add(item);
                        }
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine(string.Join(" ", filtered));
        }
        static void CommandPrintEven(List<int> toPrint)
        {
            List<int> printEven = new List<int>();
            
            for (int i = 0; i < toPrint.Count; i++)
            {
                if (toPrint[i] % 2 == 0)
                {
                    printEven.Add(toPrint[i]);
                }
            }
            
            Console.WriteLine(string.Join(" ", printEven));
        }

        static void CommandGetSum(List<int> toGet)
        {
            int sum = 0;

            foreach (var item in toGet)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }

        static void CommandPrintOdd(List<int> toPrint)
        {
            List<int> printOdd = new List<int>();

            for (int i = 0; i < toPrint.Count; i++)
            {
                if (toPrint[i] % 2 != 0)
                {
                    printOdd.Add(toPrint[i]);
                }
            }

            Console.WriteLine(string.Join(" ", printOdd));
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
