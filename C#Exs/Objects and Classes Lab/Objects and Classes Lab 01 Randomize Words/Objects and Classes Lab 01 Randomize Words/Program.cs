using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Objects_and_Classes_Lab_01_Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console
                .ReadLine()
                .Split();
            
            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int swapped = rnd.Next(input.Length);
                
                string temp = input[i];

                input[i] = input[swapped];

                input[swapped] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }


    }
}
