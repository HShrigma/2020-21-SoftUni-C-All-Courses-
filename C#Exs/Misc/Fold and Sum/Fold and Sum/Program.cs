using System;
using System.Linq;
namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toFold = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int k = toFold.Length / 4;
            
            int[] left = new int[k];
            
            for (int i = 0; i < k; i++) 
            {
                left[i] = toFold[i];
            }
            
            Array.Reverse(left);

            int[] right = new int[k];
            int pos = 0;
            for (int i = k; i > 0; i--)
            {   
                int diff = -1 + 3*k + i;
                
                right[pos] = toFold[diff];
                pos++;
            }

            int[] center = new int[k*2];
            int pos1 = 0;
            for (int i = k; i < toFold.Length - k; i++)
            {
                center[pos1] = toFold[i];
                pos1++;
            }

            int[] sum = new int[k * 2];

            for (int i = 0; i < sum.Length; i++)
            {

                if (i < k)
                {
                    sum[i] = left[i];
                }
                
                else if (i >= k)
                {
                    sum[i] = right[i - k];
                }
            }
            int[] foldAndSum = new int[2 * k];

            for (int i = 0; i < foldAndSum.Length; i++)
            {
                foldAndSum[i] = center[i] + sum[i];
                Console.Write(foldAndSum[i] + " ");
            }
        }
    }
}
