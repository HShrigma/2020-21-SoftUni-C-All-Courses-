using System;

namespace Methods_Lab_06_Rectangle_Area
{
    class Program
    {

        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            
            double area = GetRectangleArea(length, width);

            Console.WriteLine(area);
        }
        static double GetRectangleArea(double length, double width)
        {
            return length * width;
        }
    }
}
