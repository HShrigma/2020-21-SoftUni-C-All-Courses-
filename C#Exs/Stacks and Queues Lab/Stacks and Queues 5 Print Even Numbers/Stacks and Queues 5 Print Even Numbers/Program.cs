using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_5_Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> nums = new Queue<int>(input);
            while (nums.Any())
            {
                if (nums.Peek() % 2 == 0)
                {
                    if (nums.Count != 1)
                    {
                        Console.Write(nums.Dequeue() + ", ");
                    }
                    else
                    {
                        Console.WriteLine(nums.Dequeue());
                    }
                    
                }
                else
                {
                    nums.Dequeue();
                }
            }
        }
    }
}
