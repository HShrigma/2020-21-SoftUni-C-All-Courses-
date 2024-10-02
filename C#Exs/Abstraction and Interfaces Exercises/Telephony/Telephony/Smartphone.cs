using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        public void Browse(string url)
        {
            if (url.Any(char.IsDigit) || url.Any(char.IsWhiteSpace))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {url}!");
            }
        }

        public void Call(string number)
        {
            if (number.All(char.IsDigit))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
