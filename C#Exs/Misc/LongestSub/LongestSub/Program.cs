using System;
using System.Linq;

namespace LongestSub
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int lastIndex = -1;
            
            int Longest = 0;

            int[] len = new int[sequence.Length];
            
            int[] prev = new int[sequence.Length];
            
            for (int i = 0; i < sequence.Length; i++)
            {
                len[i] = 1;
                
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                   
                    if (sequence[j] < sequence[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }

                if (len[i] > Longest)
                {
                    Longest = len[i];
                    lastIndex = i;
                }
            }

            int[] LIS = new int[Longest];
            int currIndex = Longest - 1;

            while (lastIndex != -1)
            {
                LIS[currIndex] = sequence[lastIndex];
                lastIndex = prev[lastIndex];
                currIndex--;
            }
            Console.WriteLine(string.Join(" ", LIS));
        }
    }
}
