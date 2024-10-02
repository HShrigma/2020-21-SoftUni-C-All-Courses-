using System;
using System.Linq;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your desired array:");
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0; 
            
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine($"Sum is: {sum}");
        }
    }
}
