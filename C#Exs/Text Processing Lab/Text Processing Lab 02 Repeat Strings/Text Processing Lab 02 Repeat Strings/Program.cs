using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Text_Processing_Lab_02_Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console
                .ReadLine()
                .Split();

            StringBuilder final = new StringBuilder();

            foreach (var word in input)
            { 
                for (int i = 0; i < word.Length; i++)
                {
                    final.Append(word);
                }
            }

            Console.WriteLine(final);
        }
    }
}
