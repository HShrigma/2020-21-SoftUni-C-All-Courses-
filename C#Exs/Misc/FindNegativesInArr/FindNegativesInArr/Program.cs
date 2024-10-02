using System;
using System.Linq;

namespace FindNegativesInArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int negativesCount = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    negativesCount++;
                }
            }
            
            int[] negativeNums = new int[negativesCount];
            int negativeIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    negativeNums[negativeIndex] = nums[i];
                    negativeIndex++;
                }
            }
            
            Console.WriteLine($"Negative nums are: {string.Join(" ", negativeNums)}");
        }
    }
}
