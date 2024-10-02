using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            string[] toCall = ReadStrArray();

            foreach (var num in toCall)
            {
                if (num.Length == 7)
                {
                    stationaryPhone.Call(num);
                }

                else if (num.Length == 10)
                {
                    smartphone.Call(num);
                }

                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            string[] toBrowse = ReadStrArray();

            foreach (var url in toBrowse)
            {
                smartphone.Browse(url);
            }

        }

        static string[] ReadStrArray()
        {
            return Console
                .ReadLine()
                .Split();
        }
    }
}
