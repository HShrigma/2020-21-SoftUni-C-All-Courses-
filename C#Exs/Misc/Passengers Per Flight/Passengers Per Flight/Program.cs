using System;

namespace Passengers_Per_Flight
{
    class Program
    {
        static void Main(string[] args)
        {
            int airWays = int.Parse(Console.ReadLine());
            string maxCompany = "";
            double maxNum = int.MinValue;
            for (int i = 1; i <= airWays; i++)
            {
                string airWayName = Console.ReadLine();
                string input = "";
                double flightCount = 0;
                double passengerNum = 0;
                while (input != "Finish")
                {
                    input = Console.ReadLine();
                    if (input == "Finish")
                    {
                        break;
                    }
                    passengerNum+= double.Parse(input);
                    flightCount++;
                }
                double flightAvg = passengerNum / flightCount;
                if (flightAvg > maxNum)
                {
                    maxCompany = airWayName;
                    maxNum = Math.Floor(flightAvg);
                }
                Console.WriteLine($"{airWayName}: {Math.Floor(flightAvg)} passengers.");
            }
            Console.WriteLine($"{maxCompany} has most passengers per flight: {maxNum}");
        }
    }
}
