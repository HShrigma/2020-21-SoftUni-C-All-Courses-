/* Write a program that reads a list of words from the file words.txt 
 * and finds how many times each of the words is contained 
 * in another file text.txt. 
 * Matching should be case-insensitive.
 * The result should be written to another text file. 
 * Sort the words by frequency in descending order.
 * 
 * words.txt = quick is fault
 * Input.txt:
 * -I was quick to judge him, but it wasn't his fault.
 * -Is this some kind of joke?! Is it?
 * -Quick, hide here…It is safer.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Streams_files_dirs_3_word_count
{
    class Program
    {
        static void Main(string[] args)
        {
            var reference = new StreamReader("words.txt");

            using (reference)
            {
                List<string> toCount = reference
                    .ReadToEnd()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                using (var reader = new StreamReader("Input.txt"))
                {
                    Dictionary<int, CounterValue> wordCounter = new Dictionary<int, CounterValue>();
                    int index = 0;
                    foreach (var item in toCount)
                    {
                        CounterValue temp = new CounterValue()
                        {
                            Text = item,
                            Counter = 0
                        };
                        wordCounter.Add(index, temp);
                        index++;
                    }

                    string textRaw = reader.ReadToEnd();

                    string specials = ",.-!?/";
                    
                    foreach (var item in specials)
                    {
                        textRaw = textRaw.Replace(item, ' ');
                    }

                    string[] line = textRaw.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < line.Length; i++)
                    {
                        for (int j = 0; j < wordCounter.Count; j++)
                        {
                            if (line[i].ToLower() == wordCounter[j].Text.ToLower())
                            {
                                wordCounter[j].Counter++;
                            }
                        }
                    }
                    using (var writer = new StreamWriter("Output.txt"))
                    {
                        foreach (var item in wordCounter.OrderByDescending(n => n.Value.Counter))
                        {
                            writer.WriteLine($"{item.Value.Text} - {item.Value.Counter}");
                        }
                    }
                }
            }
        }
    }

    public class CounterValue
    {
        public string Text { get; set; }
        
        public int Counter { get; set; }
    }
}
