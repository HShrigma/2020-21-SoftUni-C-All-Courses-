using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace SoftUniExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeSq = cakeLength * cakeWidth;
            int piecesCount = 0;
            string input = "";
            while (input != "STOP")
            {
                input = Console.ReadLine();
                if (input == "STOP")
                { 
                    break; 
                }
                piecesCount += int.Parse(input);
                if (cakeSq < piecesCount)
                {
                    break; 
                }
            }
            if (piecesCount <= cakeSq)
            {
                Console.WriteLine($"{cakeSq - piecesCount} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {piecesCount - cakeSq} pieces more.");
            }
        }
    }
}
