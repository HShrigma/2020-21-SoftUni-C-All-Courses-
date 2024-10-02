using System;

namespace Methods_More_Exercise_03_Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());

            PrintLongerCoordinateLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void PrintLongerCoordinateLine(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            int[] point1 = new int[2] { x1, y1 };
            int[] point2 = new int[2] { x2, y2 };
            
            int[] point3 = new int[2] { x3, y3 };
            int[] point4 = new int[2] { x4, y4 };

            int[] zeroIndex = new int[2] { 0, 0 };

            int distance1 = Math.Abs(x1) * Math.Abs(y1);
            int distance2 = Math.Abs(x2) * Math.Abs(y2);
            int line1 = distance1 + distance2;

            int distance3 = Math.Abs(x3) * Math.Abs(y3);
            int distance4 = Math.Abs(x4) * Math.Abs(y4);
            int line2 = distance3 + distance4;

            if (line1 >= line2)
            {
                PrintCoordinateLine(point1, point2, distance1, distance2);
            }
            
            else if(line2 > line1)
            {
                PrintCoordinateLine(point3, point4, distance3, distance4);
            }
        }

        static void PrintCoordinateLine(int[] arr1, int[] arr2, int distance1, int distance2)
        {
            if (distance1 <= distance2)
            {
                Console.WriteLine($"({string.Join(", ", arr1)})({string.Join(", ", arr2)})");
            }
            else
            {
                Console.WriteLine($"({string.Join(", ", arr2)})({string.Join(", ", arr1)})");
            }
        }


    }
}
