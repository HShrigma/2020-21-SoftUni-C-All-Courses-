/*
 * Write a program that keeps track of a songs queue. The first song that is put in the queue, should be the first that gets played. A song cannot be added if it is currently in the queue.
 * You will be given a sequence of songs, separated by a comma and a single space. After that you will be given commands until there are no songs enqueued. When there are no more songs in the queue print "No more songs!" and stop the program.
 * The possible commands are:
 * "Play" - plays a song (removes it from the queue)
 * "Add {song}" - adds the song to the queue if it isn’t contained already, otherwise print "{song} is already contained!"
 * "Show" - prints all songs in the queue separated by a comma and a white space (start from the first song in the queue to the last)
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_Exercises_6_Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //add string arr for initial songs in following format: "{song1}, {song2}, "...", {songN}" 
            string[] init = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            //initialize queue with init array
            Queue<string> songs = new Queue<string>(init);

            //start loop until queue is empty

            while (songs.Any())
            {
                //take user inputted commands
                string[] command = Console.ReadLine().Split();

                //check for possible commands
                switch (command[0])
                {
                    case "Play":
                        
                        songs.Dequeue();

                        break;

                    case "Add":

                        string con = string.Empty;
                        for (int i = 1; i < command.Length; i++)
                        {
                            con += command[i] + " ";
                        }

                        if (songs.Contains(con.TrimEnd()))
                        {
                            Console.WriteLine($"{con.TrimEnd()} is already contained!");
                        }

                        else
                        {
                            
                            songs.Enqueue(con.TrimEnd());
                        }

                        break;

                    case "Show":

                        List<string> displaySongs = new List<string>(songs);
                        Console.WriteLine(string.Join(", ", displaySongs));
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
