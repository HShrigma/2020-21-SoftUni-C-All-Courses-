using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool winner = false;
            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                
                if (!(i - 1 < 0))
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        leftSum += nums[j];
                    }
                }

                if (!(i + 1 > nums.Length -1))
                {
                    for (int k = i + 1; k < nums.Length; k++)
                    {
                        rightSum += nums[k];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    winner = true;
                    break;
                }
            }
            if (winner == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
