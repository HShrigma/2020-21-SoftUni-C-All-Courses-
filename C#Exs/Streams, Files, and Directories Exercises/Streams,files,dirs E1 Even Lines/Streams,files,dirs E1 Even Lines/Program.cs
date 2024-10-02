using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace Streams_files_dirs_E1_Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");
            char[] toReplace = new char[5] { ',', '.', '?', '-', '|' };

            using (reader)
            {
                string line = reader.ReadLine();
                int countLines = 0;
                while (line != null)
                {
                    if (countLines % 2 == 0)
                    {
                        List<string> toPrint = new List<string>();
                        string[] lineToArr = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        foreach (var word in lineToArr.Reverse())
                        {
                            string print = string.Empty;

                            foreach (var character in word)
                            {
                                char temp;

                                if (toReplace.Contains(character))
                                {
                                    temp = '@';
                                }
                                else
                                {
                                    temp = character;
                                }
                                print += temp;
                            }

                            toPrint.Add(print);
                        }

                        Console.WriteLine(string.Join(' ', toPrint));
                    }

                    line = reader.ReadLine();
                    countLines++;
                }
            }
        }
    }
}
