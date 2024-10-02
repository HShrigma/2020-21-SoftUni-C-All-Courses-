using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace Streams_files_dirs_6_Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            //get directory
            string inputDir = 
                "C:\\Users\\Admiral Gen. Aladeen\\source\\repos\\C#Exs\\Streams,files,dirs 6 Folder Size\\Streams,files,dirs 6 Folder Size\\TestFolder";

            string[] input = Directory.GetFiles(inputDir);

            //check every file and start adding sum
            double sum = 0;
            foreach (var file in input)
            {
                FileInfo fileInfo = new FileInfo(file);

                sum += fileInfo.Length;
            }
            //fileinfo.Length gives sum in bytes. We need result in Megabytes
            //1024B = 1KB
            //1024KB = 1MB
            sum  = sum / 1024 / 1024;

            File.WriteAllText("Output.txt", sum.ToString());
        }
    }
}
