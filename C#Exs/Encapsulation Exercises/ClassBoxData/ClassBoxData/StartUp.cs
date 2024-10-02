using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<double> values = new List<double>();
            for (int i = 0; i < 3; i++)
                values.Add(double.Parse(Console.ReadLine()));
            try
            {
                Box box = new Box(values[0], values[1], values[2]);
                Console.WriteLine(box);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
