using System;
using System.Linq;
using System.Collections.Generic;

namespace Lists_Exercise_01_1._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            List<string> phrases = new List<string>() //0-5
            { 
                "Excellent product."
                , "Such a great product."
                , "I always use that product."
                , "Best product of its category."
                , "Exceptional product."
                , "I can’t live without this product." 
            };
            
            List<string> events = new List<string>() //0-5
            { 
                "Now I feel good."
                , "I have succeeded with this product."
                , "Makes miracles. I am happy of the results!"
                , "I cannot believe but now I feel awesome."
                , "Try it yourself, I am very satisfied."
                , "I feel great!" 
            };
           
            List<string> authors = new List<string> //0-7
            { 
                "Diana"
                , "Petya"
                , "Stella"
                , "Elena"
                , "Katya"
                , "Iva"
                , "Annie"
                , "Eva" 
            };
           
            List<string> places = new List<string>() //0-4
            { 
                "Burgas"
                , "Sofia"
                , "Plovdiv"
                , "Varna"
                , "Ruse" 
            };

            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                Console.WriteLine($"{phrases[random.Next(1, 6) - 1]} {events[random.Next(1, 6) - 1]} {authors[random.Next(1, 8) - 1]} - {places[random.Next(1, 5) - 1]}");
            }
        }
    }
}
