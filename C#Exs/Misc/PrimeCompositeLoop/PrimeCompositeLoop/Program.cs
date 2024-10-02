using System;
using System.Text;

namespace PrimeCompositeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int primeSum = 0;
            int compositeSum = 0;
            bool isPrime = true;
            while (input != "stop")
            {
                input = Console.ReadLine();
                isPrime = true;
                if (input == "stop")
                { 
                    break; 
                }
                int num = int.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0 && num != 0 && num != 1 && num != i)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeSum += num;
                }
                else
                {
                    compositeSum += num;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {compositeSum}");
        }
    }
}
