using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Streams_files_dirs_E3_Word_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWords = "words.txt";
            string inputText = "text.txt";
            string output = "ActualResult.txt";

            StreamReader getWords = new StreamReader(inputWords);
            StreamReader reader = new StreamReader(inputText);

            using (getWords)
            {
                string line = getWords.ReadLine();
                Dictionary<string, int> magicWords = new Dictionary<string, int>();
                while (line != null)
                {
                    string temp = string.Empty;
                    foreach (var letter in line)
                    {
                        if (char.IsLetter(letter))
                        {
                            temp += letter;
                        }
                    }
                    magicWords.Add(temp, 0);
                    line = getWords.ReadLine();
                }

                using (reader)
                {
                    string text = reader.ReadLine();

                    using (StreamWriter writer = new StreamWriter(output))
                    {
                        while (text != null)
                        {
                            string[] textToArr = text.Split();

                            foreach (var item in textToArr)
                            {
                                string getWord = string.Empty;

                                foreach (var letter in item)
                                {
                                    if (char.IsLetter(letter))
                                    {
                                        getWord += letter;
                                    }

                                    if (magicWords.ContainsKey(getWord.ToLower()))
                                    {
                                        break;
                                    }
                                }

                                if (magicWords.ContainsKey(getWord.ToLower()))
                                {
                                    magicWords[getWord.ToLower()]++;
                                }
                            }

                            text = reader.ReadLine();
                        }

                        foreach (var item in magicWords.OrderByDescending(n => n.Value))
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
