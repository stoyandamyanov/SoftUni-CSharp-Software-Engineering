using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine()
                .Split(" ");
            Article article = new Article();
            article.Autor += "";

            Console.WriteLine();
        }
    }

    class Article
    {
        

        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }

        public void Edit (string content)
        {

        }
    

    }
}



