using System;
using System.Numerics;
namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while (input != "END")
            {
                input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                BigInteger num;
                decimal dec;
                bool myBool;
                char myChar;

                if (bool.TryParse(input, out myBool) == true)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (BigInteger.TryParse(input, out num) == true)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (decimal.TryParse(input, out dec) == true)
                {
                    Console.WriteLine($"{input} is floating point type");
                }

                else if (char.TryParse(input, out myChar) == true)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
