/*We receive an integer of all the food we have for the day,
 *then we get subsequent orders in a sequence of integers,
 *we store them in a queue and print the biggest order.
 *Then we check if we have enough food for all orders.
 *If not - "Orders left: {order1} {order2} .... {orderN}",
 *if yes - print "Orders complete"
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_4_Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            //get food int
            int food = int.Parse(Console.ReadLine());
            //get all orders for this day and find the biggest one
            int[] orders = 
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //create queue for unfulfilled orders
            //we instantiate incomplete and fill it with user input
            Queue<int> incomplete = new Queue<int>(orders);

            //print biggest order
            int biggest = orders.Max();
            Console.WriteLine(biggest);

            //check if we have food and/or orders left to keep loop going
            
            while (food > 0 && incomplete.Any())
            {
                //use peek to try the taking away the order from food supply, if unsuccessful - stop loop
                if (food - incomplete.Peek() < 0)
                {
                    break;
                }
                //otherwise, take away the order from the uncompleted queue and its value from food int
                food -= incomplete.Dequeue();
            }
            //print result depending on any orders not completed yet
            if (incomplete.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", incomplete)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
