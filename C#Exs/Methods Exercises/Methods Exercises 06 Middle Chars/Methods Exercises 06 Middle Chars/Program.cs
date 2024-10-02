using System;

namespace Methods_Exercises_06_Middle_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string result = GetMiddleChar(input);
            
            Console.WriteLine(result);
        }

        static string GetMiddleChar(string getMiddleCharFrom)
        {
            var offset = getMiddleCharFrom.Length % 2 == 0 ? 1 : 0;

            string middleChar = getMiddleCharFrom.Substring(getMiddleCharFrom.Length / 2 - offset, offset + 1);
            
            return middleChar;
        }
    }
}
