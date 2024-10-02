using System;
using System.Linq;

namespace Methods_Lab_10_Multiply_Evens_by_Odds
{
    class Program
    {
        static int GetSumOfEvenDigits(int x)
        {
            int getSumOfNum = Math.Abs(x);
            int evenSum = 0;

            for (int i = getSumOfNum; i >= 1 ; i /= 10)
            {
                int checkNum = i % 10;
                if (checkNum % 2 == 0)
                {
                    evenSum += checkNum;
                }
            }
            
            return evenSum;
        }

        static int GetSumOfOddDigits(int x)
        {
            int getSumOfNum = Math.Abs(x);
            int oddSum = 0;

            for (int i = getSumOfNum; i >= 1; i /= 10)
            {
                int checkNum = i % 10;

                if (checkNum % 2 != 0)
                {
                    oddSum += checkNum;
                }
            }

            return oddSum;
        }

        static int GetEvenSumTimesOddSum(int x)
        {
            return GetSumOfEvenDigits(x) * GetSumOfOddDigits(x);
        }

        static void Main(string[] args)
        {
            int operationNum = int.Parse(Console.ReadLine());
            int evenTimesOddSum = GetEvenSumTimesOddSum(operationNum);
            Console.WriteLine(evenTimesOddSum);
        }
    }
}
