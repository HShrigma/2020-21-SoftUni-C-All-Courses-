using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_02_Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //create empty stack
            Stack<int> nums = new Stack<int>();
            
            //initialize stack with input array
            int[] init = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var item in init)
            {
                nums.Push(item);
            }

            /*check for commands:
             * add: add 2 nums(num1 and num2) to the end of stack
             * remove: remove n(count) numbers from stack. if n > element count -> skip
             * end: end loop
             */
            //create input string array(command) to check for loop
            string[] command = new string[1];
            command[0] = "";
            while (command[0].ToLower() != "end")
            {
                //assign value to command
                command = Console.ReadLine().Split();

                //check first element of command (case insensitive)
                switch (command[0].ToLower())
                {
                    case "add":
                        //push the two nums separated by whitespace
                        nums.Push(int.Parse(command[1]));
                        nums.Push(int.Parse(command[2]));
                        
                        break;

                    case "remove":
                        //check if num(n) is valid and remove n count elements
                        if (int.Parse(command[1]) <= nums.Count)
                        {
                            for (int i = int.Parse(command[1]); i > 0; i--)
                            {
                                nums.Pop();
                            }
                        }

                        break;
                    default:
                        break;
                }
            }

            //print summed value
            Console.WriteLine($"Sum: {nums.Sum()}");
        }

    }
}
