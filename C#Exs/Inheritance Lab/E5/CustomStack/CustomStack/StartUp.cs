using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();
            Console.WriteLine(stackOfStrings.IsEmpty());
            for (int i = 0; i < 11; i++)
            {
                stackOfStrings.Push(i.ToString());
            }
            Console.WriteLine(stackOfStrings.IsEmpty());
            
            string toAdd = string.Empty;

            for (int i = 50; i < 61; i++)
            {
                if (i + 1 != 61)
                    toAdd += i.ToString() + " ";
                else
                    toAdd += i.ToString();
            }

            stackOfStrings.AddRange(toAdd.Split());
            Console.WriteLine(string.Join(' ', stackOfStrings));
        }
    }
}
