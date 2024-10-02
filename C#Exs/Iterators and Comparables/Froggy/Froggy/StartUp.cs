using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake();
            lake.Create(input);
            lake.Print();

        }
    }
}
