using System;

namespace Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int loops = int.Parse(Console.ReadLine());
            string decyphered = string.Empty;
            for (int i = 0; i < loops; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int inputNum = (int)input + key; 
                decyphered += (char)inputNum;
            }
            Console.WriteLine(decyphered);
        }

    }
}
