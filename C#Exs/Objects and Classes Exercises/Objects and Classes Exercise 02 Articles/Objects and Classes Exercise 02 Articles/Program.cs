using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_and_Classes_Exercise_02_Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initialArticle = Console.ReadLine().Split(", ");

            Article article = new Article()
            {
                Title = initialArticle[0],
                Content = initialArticle[1],
                Author = initialArticle[2]
            };

            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                switch (command[0])
                {
                    case "Edit:":
                        
                        article.Content = article.Edit(article.Content, command);
                        
                        break;
                    
                    case "ChangeAuthor:":

                        article.Author = article.ChangeAuthor(article.Author, command);
                        
                        break;
                    case "Rename:":

                        article.Title = article.Rename(article.Title, command);

                        break;
                    default:
                        break;
                }
            }

            article.PrintArticle();
        }
    }

    class Article
    {
        public string Title { get; set; }
        
        public string Content { get; set; }

        public string Author { get; set; }

        public string Edit (string contentToEdit, List<string> command)
        {
            command.RemoveAt(0);
            contentToEdit = string.Join(" ", command);
            
            return contentToEdit;
        }

        public string ChangeAuthor(string authorToEdit, List<string> command)
        {
            command.RemoveAt(0);
            authorToEdit = string.Join(" ", command);
            return authorToEdit;
        }

        public string Rename(string titleToEdit, List<string> command)
        {
            command.RemoveAt(0);
            titleToEdit = string.Join(" ", command);
            return titleToEdit;
        }

        public void PrintArticle()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }
    }
}
