using System;
using System.Linq;

namespace LongestSubAlt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int longest = 0;
            int[] longestPrev = new int[nums.Length];
            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    int pos = 0;
                    int[] sumArr = new int[nums.Length];
                    sumArr[0] = nums[i];
                    int length = 0;
                    int save = 0;

                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (j + 1 != nums.Length)
                        {
                            if (nums[j - 1] >= nums[j])
                            {
                                continue;
                            }
                            else
                            {
                                sumArr[pos] = nums[j - 1];
                                length++;
                                pos++;
                            }

                        }
                    }
                    if (length > longest)
                    {
                        longest = length;
                        longestPrev = sumArr;
                    }
                }

                int[] LIS = new int[longest];
                for (int i = 0; i < longest; i++)
                {
                    LIS[i] = longestPrev[i];
                }
                Console.WriteLine(string.Join(" ", LIS));
            }
        }
    }        
}
