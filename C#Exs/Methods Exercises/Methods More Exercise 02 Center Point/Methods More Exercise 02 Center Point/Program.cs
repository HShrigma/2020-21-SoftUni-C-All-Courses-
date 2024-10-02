using System;

namespace Methods_More_Exercise_02_Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            long x1 = long.Parse(Console.ReadLine());
            long y1 = long.Parse(Console.ReadLine());
            long x2 = long.Parse(Console.ReadLine());
            long y2 = long.Parse(Console.ReadLine());

            CheckTwoPointsClosestTox0y0CoordinateSystem(x1, y1, x2, y2);

        }

        static void CheckTwoPointsClosestTox0y0CoordinateSystem(double x1, double y1, double x2, double y2)
        {
            double[] point1 = new double[2] { x1, y1};
            double[] point2 = new double[2] { x2, y2};
            double[] zeroIndex = new double[2] { 0, 0 };

            double distance1 = Math.Abs(x1) * Math.Abs(y1);
            double distance2 = Math.Abs(x2) * Math.Abs(y2);

            if (distance1 == distance2)
            {
                Console.WriteLine($"({string.Join(", ", point1)})");
            }
            else if (distance1 < distance2)
            {
                Console.WriteLine($"({string.Join(", ", point1)})");
            }
            else
            {
                Console.WriteLine($"({string.Join(", ", point2)})");
            }
        }
    }

}
