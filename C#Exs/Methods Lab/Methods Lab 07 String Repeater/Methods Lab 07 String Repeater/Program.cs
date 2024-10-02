using System;

namespace Methods_Lab_07_String_Repeater
{
    class Program
    {
        static string StringRepeater(string toRepeat, int loops) 
        {
            string finalConcatStr = string.Empty;

            for (int i = 0; i < loops; i++)
            {
                finalConcatStr += toRepeat;
            }

            return finalConcatStr;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int reps = int.Parse(Console.ReadLine());

            string repeated = StringRepeater(input, reps);

            Console.WriteLine(repeated);
        }
    }
}
