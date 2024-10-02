using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] fibonacci = new int[n];
            for (int i = 0; i < n; i++)
            {
                switch (i)
                {
                    case 0:
                    case 1:
                        fibonacci[i] = 1;
                        break;
                    default:
                        fibonacci[i]= fibonacci[i - 1] + fibonacci[i - 2];
                        break;
                }
            }
            Console.WriteLine(fibonacci[n - 1]);
        }
    }
}
