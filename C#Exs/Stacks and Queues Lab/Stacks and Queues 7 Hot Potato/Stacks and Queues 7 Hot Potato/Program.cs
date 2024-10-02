using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_7_Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input then turn into queue, get user input on which cycle a player should drop at
            string[] players = Console.ReadLine().Split();
            Queue<string> game = new Queue<string>(players);
            
            int n = int.Parse(Console.ReadLine());

            while (game.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    game.Enqueue(game.Dequeue());
                }

                Console.WriteLine($"Removed {game.Dequeue()}");
            }
            //print last player
            Console.WriteLine($"Last is {game.Dequeue()}");
        }
    }
}
