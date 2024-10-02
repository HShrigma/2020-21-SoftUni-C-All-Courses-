using System;

namespace Sum_of_two
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int first = int.Parse(Console.ReadLine()); 
            int second = int.Parse(Console.ReadLine()); 
            int magic = int.Parse(Console.ReadLine());   
            int a = first;
            int b = first;
            int combiNum = 0;
            for (int n = first; n <= second; n++)
            {
                a = n;
                for (int o = first; o <= second; o++ )
                {
                    b = o;
                    int sum = a + b;
                    combiNum++;
                    if (sum == magic)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                { 
                    break; 
                }
            }
            if (flag)
            {
                Console.WriteLine($"Combination N:{combiNum} ({a} + {b} = {magic})");
            }
            else
            {
                Console.WriteLine($"{combiNum} combinations - neither equals {magic}");
            }
        }
    }
}
