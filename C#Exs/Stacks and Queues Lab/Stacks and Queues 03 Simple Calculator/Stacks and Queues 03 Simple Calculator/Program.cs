//This calculator will make additions and substractions on one line
//ex: 1 + 2 + 3 - 4
//ex out: 2
//It will use a stack to perform the actions
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_03_Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input into array and reverse into stack
            string[] input = Console
                .ReadLine()
                .Split()
                .Reverse()
                .ToArray();
            
            Stack<string> calculationRaw = new Stack<string>(input);
            //get result var and set it to first element

            int result = int.Parse(calculationRaw.Pop());
            //loop through possible operators
            while (calculationRaw.Any())
            {
                switch (calculationRaw.Pop())
                {
                    case "+":
                        result += int.Parse(calculationRaw.Pop());
                        break;
                    case "-":
                        result -= int.Parse(calculationRaw.Pop());
                        break;
                    default:
                        break;
                }
            }

            //print result
            Console.WriteLine(result);
        }
    }
}
