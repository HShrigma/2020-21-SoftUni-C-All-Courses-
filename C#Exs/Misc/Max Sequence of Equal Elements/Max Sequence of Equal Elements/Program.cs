using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int leftIndex = 0;
            int biggest = int.MinValue;
            int count = 0;
            int rightIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int leftTemp = i;
                int rightTemp = i;
                count = 0;
                for (int j = i + 1; j  < nums.Length; j ++)
                {
                    if (nums[j] == nums[i])
                    {
                        count++;
                        rightTemp = j;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > biggest)
                {
                    biggest = count;
                    leftIndex = leftTemp;
                    rightIndex = rightTemp;
                }
            }
            for (int k = leftIndex; k <= rightIndex; k++)
            {
                Console.Write($"{nums[k]} ");
            }
        }
    }
}
