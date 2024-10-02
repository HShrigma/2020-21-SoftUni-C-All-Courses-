using System;
using System.Linq;

namespace SumEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[arr1.Length - 1];
            
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                condensed[i] = arr1[i] + arr1[i + 1];
            }
            int sum = 0;

            for (int i = 0; i < condensed.Length; i++)
            {
                int temp = condensed[i];
                sum += temp;
            }
            Console.WriteLine(sum);
        }
    }
}
