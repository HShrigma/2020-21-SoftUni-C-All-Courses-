using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_01_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reverse = new Stack<char>();

            foreach (var character in input)
            {
                reverse.Push(character);
            }

            while (reverse.Count != 0)
            {
                Console.Write(reverse.Pop());
            }
        }
    }
}
