using System;
using System.Collections.Generic;
using System.Linq;

namespace Adcanced_Test_Tinker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] vs = new string[3, 3];
            vs[0, 1] = "abc";
            vs[1, 1] = "abcdefg";
            Console.WriteLine(vs.GetLength(1));
        }
    }
}
