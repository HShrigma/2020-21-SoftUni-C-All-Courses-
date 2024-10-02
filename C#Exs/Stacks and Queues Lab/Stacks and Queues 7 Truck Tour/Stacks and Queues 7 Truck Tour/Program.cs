/*Suppose there is a circle. There are N petrol pumps on that circle. Petrol pumps are numbered 0 to (N−1) (both inclusive).
* You have two pieces of information corresponding to each of the petrol pump: (1) the amount of petrol that particular petrol pump will give,
* and (2) the distance from that petrol pump to the next petrol pump.
* Initially, you have a tank of infinite capacity carrying no petrol. You can start the tour at any of the petrol pumps. 
* Calculate the first point from where the truck will be able to complete the circle. Consider that the truck will stop at each of the petrol pumps. 
* The truck will move one kilometer for each liter of the petrol.
* 
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_7_Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            //get N
            int n = int.Parse(Console.ReadLine());

            //create pumps and init with for loop n times
            Queue<Pump> pumps = new Queue<Pump>();
            
            for (int i = 0; i < n; i++)
            {
                int[] input = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                
                Pump temp = new Pump 
                { 
                    number = i, 
                    litres = input[0], 
                    distance = input[1]
                };

                pumps.Enqueue(temp);
            }
            //create litre tracker and loop through Queue
            bool found = false;
            int winner = default;

            while (found == false)
            {
                int litreTrack = pumps.Peek().litres - pumps.Peek().distance;

                if (litreTrack >= 0)
                {
                    pumps.Enqueue(pumps.Dequeue());
                    for (int i = 1; i < n; i++)
                    {
                        litreTrack += pumps.Peek().litres - pumps.Peek().distance;

                        if (litreTrack < 0)
                        {
                            break;
                        }
                        else
                        {
                            pumps.Enqueue(pumps.Dequeue());
                        }

                        if (i == n - 1)
                        {
                            found = true;
                            winner = pumps.Peek().number;
                            break;
                        }
                    }
                }
                else
                {
                    pumps.Enqueue(pumps.Dequeue());
                }
            }

            //print result
            Console.WriteLine(winner);
        }
    }

    public class Pump
    {
        public int number { get; set; }
        public int litres { get; set; }

        public int distance { get; set; }
    }
}
