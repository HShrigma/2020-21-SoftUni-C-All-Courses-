using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 10.0;
            while(num < 11)
            {
                double num32 = Math.Floor(num);
                Console.WriteLine(num32);
                num += .1;
            }
        }
    }
}
