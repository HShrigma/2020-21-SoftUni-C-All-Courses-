using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int l = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int i1 = 1; i1 <= n; i1++)
                {
                    for (int i2 = 'a'; i2 < 'a' + l; i2++)
                    {
                        for (int i3 = 'a'; i3 < 'a' + l; i3++)
                        {
                            for (int i4 = 2; i4 <=n ; i4++)
                            {
                                if (i4 > i && i4 > i1)
                                { 
                                    Console.Write($"{i}{i1}{(char)i2}{(char)i3}{i4} "); 
                                }
                            }
                        }
                    }
                }
            }            
        }
    }
}
