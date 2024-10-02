using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_8_Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int passTracker = 0;

            string input = string.Empty;
            while (input != "end")
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "green":
                        for (int i = 0; i < n; i++)
                        {
                            if (cars.Any())
                            {
                                Console.WriteLine($"{cars.Dequeue()} passed!");
                                passTracker++;
                            }                         
                        }
                        break;
                    case "end":
                        break;
                    default:
                        cars.Enqueue(input);
                        break;
                }
            }

            Console.WriteLine($"{passTracker} cars passed the crossroads.");
        }
    }
}
