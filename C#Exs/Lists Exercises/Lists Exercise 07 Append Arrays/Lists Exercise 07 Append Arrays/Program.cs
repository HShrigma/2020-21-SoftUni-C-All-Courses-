using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise_07_Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            
            Array.Reverse(input);
            
            List<int> permaSorted = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                List<int> tempSort = new List<int>();
                
                foreach (var item in input[i])
                {
                    if (item != ' ')
                    {
                        tempSort.Add(int.Parse(item.ToString()));
                    }
                }

                foreach (var num in tempSort)
                {
                    permaSorted.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", permaSorted));
        }
    }
}
