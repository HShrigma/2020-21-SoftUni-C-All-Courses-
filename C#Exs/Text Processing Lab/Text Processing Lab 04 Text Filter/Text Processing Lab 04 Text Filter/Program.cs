using System;
using System.Collections.Generic;
using System.Linq;

namespace Text_Processing_Lab_04_Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console
                .ReadLine()
                .Split(", ");

            string text = Console.ReadLine();

            foreach (var bannedWord in banned)
            {
                while (text.Contains(bannedWord))
                {
                    string asterisk = new string('*', bannedWord.Length);
                    text = text.Replace(bannedWord, asterisk);
                }
            }

            Console.WriteLine(text);
        }
    }
}
