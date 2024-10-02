using System;

namespace Methods_Exercise_07_NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            PrintNxNMatrix(num);
        }

        static void PrintNxNMatrix(int n)
        {
            int[] printRow = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
