using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.IO.Compression;

namespace Streams_files_dirs_E6_Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            //get copyMe file
            string toZip = @"copyMe.png";
            //get user input for Directory to zip File
            Console.WriteLine("Choose path to zip to:");
            string zipToDir = Console.ReadLine();
            //get user input for Directory to extract
            Console.WriteLine("Choose path to extract to:");
            string extractToDir = Console.ReadLine();

            ZipFile.CreateFromDirectory(toZip, zipToDir+"\\zipped.zip");
            ZipFile.ExtractToDirectory(zipToDir, extractToDir+"\\extracted.png");
        }
    }
}
