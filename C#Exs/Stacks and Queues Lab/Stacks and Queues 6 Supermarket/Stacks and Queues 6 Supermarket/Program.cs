using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_6_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            string input = string.Empty;

            while (input != "End")
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "Paid":
                        while (customers.Any())
                        {
                            Console.WriteLine(customers.Dequeue());
                        }
                        break;
                    case "End":
                        break;
                    default:
                        customers.Enqueue(input);
                        break;
                }
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
