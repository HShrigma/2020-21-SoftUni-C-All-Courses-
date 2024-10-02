using System;

namespace Methods_More_Exercise_04_Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTribonacciUpToNum(n);
        }

        static void PrintTribonacciUpToNum(int print)
        {
            int testNum = 1;
            int storeNum1 = 0;
            int storeNum2 = 0;
            int storeNum3 = 0;

            while (print > 0)
            {
                Console.Write(testNum + " ");
                storeNum3 = storeNum2;
                storeNum2 = storeNum1;
                storeNum1 = testNum;
                testNum = storeNum1 + storeNum2 + storeNum3;
                print--;
            }
        }
    }
}
