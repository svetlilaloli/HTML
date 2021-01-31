using HTML.ClassLibrary;
using System;

namespace HTML
{
    class HTML
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string comment = Console.ReadLine();
            Article article = new Article
            {
                Title = title,
                Content = content
            };

            while (comment != "end of comments")
            {
                article.Comments.Add(comment);
                comment = Console.ReadLine();
            }
            PrintInHTML(article);
        }

        private static void PrintInHTML(Article article)
        {
            if (article.Title != null)
            {
                Console.WriteLine("<h1>");
                Console.WriteLine($"\t{article.Title}");
                Console.WriteLine("</h1>");
            }
            if (article.Content != null)
            {
                Console.WriteLine("<article>");
                Console.WriteLine($"\t{article.Content}");
                Console.WriteLine("</article>");
            }
            foreach (string comment in article.Comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"\t{comment}");
                Console.WriteLine("</div>");
            }
        }
    }
}
