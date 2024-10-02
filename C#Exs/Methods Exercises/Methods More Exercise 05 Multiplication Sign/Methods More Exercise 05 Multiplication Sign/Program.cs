using System;

namespace Methods_More_Exercise_05_Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine(NegativePositiveOrZeroXTimesYTimesZ(x, y, z)); 
        }


        static string NegativePositiveOrZeroXTimesYTimesZ(int x, int y, int z)
        {
            int negativeCount = 0;
            bool isZero = false;

            int[] zeroCheck = new int[3] { x, y, z };

            foreach (var item in zeroCheck)
            {
                isZero = CheckIfNumIsZero(item);
                if (isZero == true)
                {
                    return "zero";
                }
                if (item < 0)
                {
                    negativeCount++;
                }
            }

            if (negativeCount % 2 == 0)
            {
                return "positive";
            }

            else
            { 
                return "negative"; 
            }
        }

        static bool CheckIfNumIsZero(int toCheck)
        {
            bool isZero = false;
            if (toCheck == 0)
            {
                isZero = true;
            }
            return isZero;
        }
    }
}
