using System;
using System.Linq;
namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] nums = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                bool topCheck = false;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        topCheck = true;
                    }
                    else
                    {
                        topCheck = false;
                        break;
                    }
                }
                if (topCheck == true)
                {
                    Console.Write($"{nums[i]} ");
                }
            }
            Console.Write($"{nums[nums.Length-1]}");

        }
    }
}
