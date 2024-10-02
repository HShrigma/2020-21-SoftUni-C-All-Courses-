using System;
using System.Linq;

namespace ArrayUniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                bool isUnique = true;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                { 
                    Console.Write($"{nums[i]} ");
                }
            }
        }
    }
}
