using System;
using System.Collections.Generic;
using System.Linq;

namespace Text_Processing_Exercise_03_Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] address = Console.ReadLine().Split('\\');

            List<string> FileAndExtension = new List<string>();

            foreach (var item in address)
            {
                if (item.Contains('.'))
                {
                    FileAndExtension = item.Split('.').ToList();
                }
            }

            Console.WriteLine($"File name: {FileAndExtension[0]}");

            Console.WriteLine($"File extension: {FileAndExtension[1]}");
        }
    }
}
