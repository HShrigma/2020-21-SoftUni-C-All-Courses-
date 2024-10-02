using System;

namespace refactoring_prime_check
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            
            for (int i = 2; i <= loops; i++)
            {
                bool primecheck = true;
                
                for (int divider = 2; divider < i; divider++)
                {
                    if (i % divider == 0)
                    {
                        primecheck = false;
                        break;
                    }
                }
                string res = primecheck.ToString().ToLower();
                Console.WriteLine($"{i} -> {res}");
            }
        }
    }
}
