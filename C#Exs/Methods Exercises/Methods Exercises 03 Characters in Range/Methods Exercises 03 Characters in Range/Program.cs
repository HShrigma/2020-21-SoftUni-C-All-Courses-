using System;

namespace Methods_Exercises_03_Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = char.Parse(Console.ReadLine());
            int y = char.Parse(Console.ReadLine());

            string res = GetASCIICharactersInRange(x, y);

            Console.WriteLine(res);
        }

        static string GetASCIICharactersInRange(int x, int y)
        {
            string result = string.Empty;
            int numOne = 0;
            int numTwo = 0;
            if (x < y)
            {
                numOne = x;
                numTwo = y;
            }
            else
            {
                numOne = y;
                numTwo = x;
            }
            for (int i = numOne + 1; i < numTwo; i++)
            {
                char intToChar = (char)i;

                result += intToChar + " ";
            }

            return result;
        }
    }
}
