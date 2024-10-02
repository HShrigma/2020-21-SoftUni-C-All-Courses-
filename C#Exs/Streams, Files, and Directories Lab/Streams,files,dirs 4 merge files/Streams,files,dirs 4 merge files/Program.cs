/*Write a program that reads the contents of two text files and merges them together into a third one.
 * ex:
 * Input1:
 * 1
 * 3
 * 5
 * Input2:
 * 2
 * 4
 * 6
 * Otput:
 * 1
 * 2
 * 3
 * 4
 * 5
 * 6
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Streams_files_dirs_4_merge_files
{
    class Program
    {
        static void Main(string[] args)
        {
            var readerOdd = new StreamReader("Input2.txt");
            var readerEven = new StreamReader("Input1.txt");

            using (readerOdd)
            {
                string lineOdd = readerOdd.ReadLine();
                using (readerEven)
                {
                    string lineEven = readerEven.ReadLine();

                    using (var writer = new StreamWriter("Output.txt"))
                    {
                        int counter = 0;

                        while (lineEven != null && lineOdd != null)
                        {
                            if (counter % 2 == 0)
                            {
                                writer.WriteLine(lineEven);
                                lineEven = readerEven.ReadLine();
                            }
                            else
                            {
                                writer.WriteLine(lineOdd);
                                lineOdd = readerOdd.ReadLine();
                            }
                            counter++;
                        }
                        writer.WriteLine(lineOdd);
                    }
                }
            }
        }
    }
}
