using System;

namespace Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double avgSpeedKmPH = double.Parse(Console.ReadLine());
            double fuel100Km = double.Parse(Console.ReadLine());
            double fuel1Km = fuel100Km / 100;
            double distanceKm = 384400.00 * 2;
            double timeH = distanceKm / avgSpeedKmPH;
            double totalTime = timeH + 3.00;
            double fuelTotal = distanceKm * fuel1Km;
            Console.WriteLine(Math.Ceiling(totalTime));
            Console.WriteLine(Math.Round(fuelTotal));


        }
    }
}
