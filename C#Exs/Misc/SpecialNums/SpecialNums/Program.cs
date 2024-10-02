using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;

namespace SpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1000; i <= 9000; i+= 1000)
            {
                for (int j = 100; j <= 900; j+= 100)
                {
                    for (int k = 10; k <= 90; k+= 10)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            int sum = i + j + k + l;
                            int num1 = i / 1000;
                            int num2 = j / 100;
                            int num3 = k / 10;
                            int num4 = l;
                            if (n % num1 == 0 && n % num2 == 0 && n % num3 == 0 && n % num4 == 0)
                            { 
                                Console.Write(sum + " "); 
                            }
                        }
                    }
                }
            }
        }
    }
}
