using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<string> stack = new CustomStack<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Push":

                        string[] toPush = string.Join(' ', command.Skip(1))
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                        stack.Push(toPush);

                        break;

                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;

                    default:
                        break;
                }
            }

            if (stack.Any())
            {
                Console.WriteLine(string.Join('\n', stack));
                Console.WriteLine(string.Join('\n', stack));

            }
        }
    }
}
