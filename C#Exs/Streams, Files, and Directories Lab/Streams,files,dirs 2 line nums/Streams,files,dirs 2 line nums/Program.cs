/* Write a program that reads a text file 
 * and inserts line numbers in front of each of its lines. 
 * The result should be written to another text file. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Streams_files_dirs_2_line_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            //create reader to read from Input file we made in project folder
            var reader = new StreamReader("Input.txt");

            using (reader)
            {
                //make a string to read a line from it
                //and a counter to number lines
                string line = reader.ReadLine();
                int counter = 1;

                //create writer to export output onto
                //a (not yet existing) .txt file it will create
                using (var writer = new StreamWriter("Output.txt"))
                {
                    //check if line becomes null aka it is trying to read lines with
                    //no data, not even spaces or newlines
                    while (line != null)
                    {
                        //example input:
                        //Hello
                        //...
                        //Goodbye
                        //example output:
                        //1. Hello
                        //...
                        //n. Goodbye

                        writer.WriteLine($"{counter}. {line}");
                        
                        counter++;
                        line = reader.ReadLine(); //read next line
                    }
                }
            }
        }
    }
}
