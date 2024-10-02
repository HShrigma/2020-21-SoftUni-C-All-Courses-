using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Streams_files_dirs_E5_Dir_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string desktop = Environment
                .GetFolderPath(Environment.SpecialFolder.Desktop);
            //get directory
            //sample directory: D:\Games
            Console.WriteLine("Please enter your desired directory:");
            string input = Console.ReadLine();

            Dictionary<string, List<FileInfo>> dir = new Dictionary<string, List<FileInfo>>();

            foreach (var item in Directory.GetFiles(input))
            {
                string extension = item.Substring(item.LastIndexOf('.'));
                FileInfo fileInfo = new FileInfo(item);
                
                if (dir.ContainsKey(extension))
                {
                    dir[extension].Add(fileInfo);
                }
                else
                {
                    List<FileInfo> temp = new List<FileInfo>();
                    temp.Add(fileInfo);
                    dir.Add(extension, temp);
                }
            }

            using (StreamWriter writer = new StreamWriter(desktop+"\\report.txt"))
            {
                foreach (var item in dir.OrderByDescending(n => n.Value.Count).ThenBy(n => n.Key))
                {
                    writer.WriteLine(item.Key);

                    foreach (var file in item.Value.OrderBy(n => n.Length))
                    {
                        double kb = file.Length / 1024;

                        writer.WriteLine($"--{file.Name} - {kb}kb");
                    }
                }
            }
        }
    }
}
