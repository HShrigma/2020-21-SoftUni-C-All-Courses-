using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise_03_House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            
            List<string> guests = new List<string>();
          
            for (int i = 0; i < commandCount; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                switch (input[2])
                {
                    case "going!":
                        if (CheckName(guests, input))
                        {
                            Console.WriteLine($"{input[0]} is already in the list!");
                        }
                        else
                        {
                            guests.Add(input[0]);
                        }
                        
                        break;
                    
                    case "not":

                        if (CheckName(guests, input))
                        {
                            guests.Remove(input[0]);
                        }
                        else
                        {
                            Console.WriteLine($"{input[0]} is not in the list!");
                        }

                        break;

                    default:
                        break;
                }
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }

            static bool CheckName(List<string> toCheck, List<string> zeroIsName)
            {
                bool hasName = false;

                foreach (var name  in toCheck)
                {
                    if (name == zeroIsName[0])
                    {
                        hasName = !(hasName);
                        break;
                    }
                }
                return hasName;
            }
        }
    }
}
