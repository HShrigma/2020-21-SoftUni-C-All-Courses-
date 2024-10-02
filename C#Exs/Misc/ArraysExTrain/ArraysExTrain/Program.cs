using System;
using System.Linq;

namespace ArraysExTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string passangersText = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int passengersTemp = int.Parse(Console.ReadLine());
                passangersText += passengersTemp + " ";
            }
            passangersText = passangersText.Substring(0, passangersText.Length-1);
            int[] passengersPerWag = passangersText
                .Split()
                .Select(int.Parse)
                .ToArray();
            foreach (var item in passengersPerWag)
            {
                Console.Write(item + " ");
            }

            int sum = 0;
            for (int i = 0; i < passengersPerWag.Length; i++)
            {
                int temp = passengersPerWag[i];
                sum += temp;
            }
            Console.WriteLine("\n" + sum);
        }
    }
}
