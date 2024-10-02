using System;
using System.Linq;

namespace ArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string arrToStr = string.Empty;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arrToStr += arr[i].ToString() + ' ';
            }
            Console.WriteLine(arrToStr);
        }
    }
}
