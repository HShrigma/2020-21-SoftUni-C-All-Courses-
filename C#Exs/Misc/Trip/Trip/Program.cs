using System;
using System.IO;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (done == false)
            { 
                double saved = 0;
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    done = true;
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                while (saved < budget)
                {
                    string input = Console.ReadLine();
                    if (input == "End")
                    { 
                        done = true;
                        break;
                    }
                    saved += double.Parse(input);
                }
                if (done)
                { 
                    break; 
                }
                Console.WriteLine($"Going to {destination}!");
            }

        }
    }
}
