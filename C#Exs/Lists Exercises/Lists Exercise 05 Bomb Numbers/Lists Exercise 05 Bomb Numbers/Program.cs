using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise_05_Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> specialAndPowerNums = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int special = specialAndPowerNums[0];
            int power = specialAndPowerNums[1];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == special)
                {
                    nums = DetonateRight(nums, power, i);
                    nums.RemoveAt(i);
                    nums = DetonateLeft(nums, power, i);
                    i = -1;
                }
            }
            int sum = 0;
            
            foreach (var item in nums) 
            {
                sum += item; 
            }
            Console.WriteLine(sum);
        }

        static List<int> DetonateRight(List<int> numsToDetonateOn, int pow, int index)
        {
            int powCount = 0;
                for (int i = index + 1; i < numsToDetonateOn.Count; i++)
                {
                    numsToDetonateOn.RemoveAt(i);
                    powCount++;
                    if (powCount == pow)
                    {
                        break;
                    }
                }
            
            return numsToDetonateOn;
        }
        
        static List<int> DetonateLeft(List<int> numsToDetonateOn, int pow, int index)
        {
            int powCount = 0;
                int indexOfDet = index - pow;
                
            while (indexOfDet < 0)
            {
                indexOfDet++;
                pow--;
            }
               
            while(powCount != pow)
            {
                numsToDetonateOn.RemoveAt(indexOfDet);
                powCount++;
            }
            
            return numsToDetonateOn;
        }
    }
}
