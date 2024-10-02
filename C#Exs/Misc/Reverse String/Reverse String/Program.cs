using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] wordCount = word.ToCharArray();
            string reverse = string.Empty;
            for (int i = wordCount.Length - 1; i > -1 ; i--)
            {
                reverse += wordCount[i]; 
            }
            Console.WriteLine(reverse);
        }
    }
}
