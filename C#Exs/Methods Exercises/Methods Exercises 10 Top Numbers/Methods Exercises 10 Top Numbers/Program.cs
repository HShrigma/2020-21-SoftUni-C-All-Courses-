using System;

namespace Methods_Exercises_10_Top_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int cap = int.Parse(Console.ReadLine());

            TopNumsCheck(cap);

        }

        //a number is top if 1: digit sum is divisible by 8, 2: at least one odd digit exists
        static void TopNumsCheck(int CheckfromOneTo)
        {
            for (int i = 1; i <= CheckfromOneTo; i++)
            {
                if (DigitsDivisibleBy8Check(i) == true && OddDigitCheck(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool DigitsDivisibleBy8Check(int x)
        {
            bool isDivBy8 = false;
            
            int digitSum = 0;
            
            for (int i = x; i > 0; i /=10)
            {
                digitSum += i % 10;
            }

            if (digitSum % 8 == 0)
            {
                isDivBy8 = true;
            }
            return isDivBy8;
        }
        
        static bool OddDigitCheck(int x)
        {
            bool isOdd = false;
            for (int i  = x; i > 0; i /= 10)
            {
                int currentDigit = i % 10;
                
                if (currentDigit % 2 != 0)
                {
                    isOdd = true;
                    break;
                }
            }

            return isOdd;
        }
    }
}
