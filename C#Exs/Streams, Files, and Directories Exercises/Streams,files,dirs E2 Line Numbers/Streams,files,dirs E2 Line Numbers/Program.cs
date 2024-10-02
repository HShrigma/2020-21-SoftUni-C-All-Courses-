using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Streams_files_dirs_E2_Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int letters = 0, marks = 0,lineCount = 1;

            string input = "text.txt";

            StreamReader reader = new StreamReader(input);

            using (reader)
            {
                string line = reader.ReadLine();
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    while (line != null)
                    {
                        string[] lineToArr = line
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                        foreach (var word in lineToArr)
                        {
                            foreach (var symbol in word)
                            {
                                if (char.IsPunctuation(symbol))
                                {
                                    marks++;
                                }
                                if (char.IsLetter(symbol))
                                {
                                    letters++;
                                }
                            }
                        }
                        Console.WriteLine($"Line {lineCount}: {line} ({letters})({marks})");
                        lineCount++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
