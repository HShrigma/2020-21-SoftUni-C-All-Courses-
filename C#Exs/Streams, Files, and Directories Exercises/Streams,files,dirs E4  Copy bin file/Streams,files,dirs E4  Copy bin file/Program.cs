using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Streams_files_dirs_E4__Copy_bin_file
{
    class Program
    {
        static void Main(string[] args)
        {
            //get file in dir based on user input
            //sample fileName: imperatora
            //sample fileExtension: .jpg
            string fileName = Console.ReadLine();
            string fileExtension = Console.ReadLine();
            FileStream input = new FileStream(fileName+fileExtension, FileMode.Open, FileAccess.Read);

            using (input)
            {
                using (FileStream output = new FileStream("output"+fileExtension, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte [1024]; 
                    //we make a buffer the length of 1KB.
                    //A possible side solution would be making buffer length = input.Length (aka the size of the file)
                    //however, then using a loop would be redundant and I wanted to test if an error will be thrown in my face

                    int bytesRead; //we then keep track of bytes already Read, input.Read cycles through data meanwhile

                    while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}
