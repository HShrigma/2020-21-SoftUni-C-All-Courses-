using System;
using System.Runtime.ExceptionServices;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int combinations = 0;
            for (int first = 0; first <= n; first++)
            {
                for (int second = 0; second <= n; second++)
                {
                    for (int third = 0; third <= n; third++)
                    {
                        int sum = first + second + third;
                        if(sum == n)
                        {
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
