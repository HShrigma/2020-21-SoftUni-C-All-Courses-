using System;
using System.Collections.Generic;
using System.Linq;

namespace Text_Processing_Exercise_04_Caesar_Cypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string cyphered = string.Empty;
            
            for (int i = 0; i < input.Length; i++)
            {
                char cypherChar = (char)(input[i] + 3);

                cyphered += cypherChar;
            }

            Console.WriteLine(cyphered);
        }
    }
}
