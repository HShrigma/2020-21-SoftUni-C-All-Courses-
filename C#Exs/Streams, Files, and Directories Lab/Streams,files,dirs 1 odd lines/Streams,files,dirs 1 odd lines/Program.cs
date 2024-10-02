/* Write a program that reads a text file and 
 * writes it's every odd line in another file. 
 * Line numbers starts from 0. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Streams_files_dirs_1_odd_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("Input.txt");

            using (reader)
            {
                int counter = 0;
                string line = reader.ReadLine();

                using (var writer = new StreamWriter("Output.txt"))
                {
                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
