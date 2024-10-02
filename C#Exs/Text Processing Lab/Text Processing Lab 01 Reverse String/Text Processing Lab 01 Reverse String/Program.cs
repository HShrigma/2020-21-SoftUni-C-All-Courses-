using System;
using System.Collections.Generic;
using System.Linq;

namespace Text_Processing_Lab_01_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while (input != "end")
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "end":
                        break;
                    
                    default:
                        string rev = string.Empty;

                        for (int i = input.Length - 1; i >= 0; i--)
                        {
                            rev += input[i];
                        }
                        Console.WriteLine($"{input} = {rev}");
                        break;
                }
            }
        }
    }
}
