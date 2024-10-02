using System;
using System.Linq;
using System.Collections.Generic;

namespace Objects_and_Classes_Lab_03_Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < loops; i++)
            {
                string[] songDetails = Console
                    .ReadLine()
                    .Split("_");

                Song song = new Song();
                
                song.TypeList = songDetails[0];
                song.Name = songDetails[1];
                song.Time = songDetails[2];

                songs.Add(song);
            }

            string getType = Console.ReadLine();

            foreach (var item in songs)
            {
                if (item.TypeList == getType || getType == "all")
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
