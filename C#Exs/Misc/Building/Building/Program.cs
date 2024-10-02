using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorCount = int.Parse(Console.ReadLine());
            int roomCount = int.Parse(Console.ReadLine());
            char office = 'O';
            char apartment = 'A';
            char last = 'L';
            int roomNum = 0;
            for (int floor = floorCount; floor >= 1 ; floor--)
            {
                for (int room = 0; room < roomCount; room++)
                {
                    roomNum = floor * 10;
                    roomNum += room;
                    if (floor == floorCount)
                    {
                        Console.Write($"{last}{roomNum} ");
                    }
                    else if (floor % 2 == 0 && floor != floorCount)
                    {
                        Console.Write($"{office}{roomNum} ");
                    }
                    else
                    {
                        Console.Write($"{apartment}{roomNum} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
