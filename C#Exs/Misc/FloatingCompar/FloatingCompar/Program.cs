using System;

namespace LeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            long digits = 0;

            for (int i = 0; i < loops; i++)
            {
                string input = Console.ReadLine();
                string leftNumString = input.Substring(0, input.IndexOf(" "));
                string rightNumString = input.Substring(input.IndexOf(" ") + 1);
                long leftNum = long.Parse(leftNumString);
                long rightNum = long.Parse(rightNumString);
                if (leftNum >= rightNum)
                {
                    digits = Math.Abs(leftNum);
                }
                else
                {
                    digits = Math.Abs(rightNum);
                }
                int sum = 0;
                while (digits > 0) 
                {
                    long lastdigit = digits % 10;
                    sum += (int)lastdigit;
                    digits /= 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
