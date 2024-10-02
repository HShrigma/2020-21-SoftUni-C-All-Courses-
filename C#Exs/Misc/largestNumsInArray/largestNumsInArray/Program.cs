using System;
using System.Linq;

namespace largestNumsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int largest = int.MinValue;

            int secondLargest = int.MinValue;

            int thirdLargest = int.MinValue;

            int prev = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > largest)
                {
                    thirdLargest = secondLargest;
                    secondLargest = largest;
                    largest = nums[i];
                }
               
                if (nums[i] < largest && nums[i] > secondLargest)
                {
                    thirdLargest = secondLargest;
                    secondLargest = nums[i];
                }
                
                if (nums[i] < secondLargest && nums[i] > thirdLargest)
                {
                    thirdLargest = nums[i];
                }

                prev = nums[i];
            }
            Console.WriteLine($"1st: {largest}");
            Console.WriteLine($"2nd: {secondLargest}");
            Console.WriteLine($"3rd: {thirdLargest}");
        }
    }
}
