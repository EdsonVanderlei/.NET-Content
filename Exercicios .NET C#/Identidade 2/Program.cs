using Identidade_2.Entities;
using System;

namespace Identidade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("have a nice Trip ! ");
            Comment c2 = new Comment("Wow that's Awesome!");

            Post p1 = new Post(DateTime.Now, "Traveling to New Zealand", " I'm going to visit this wonderful country", 12);

            p1.AddComment(c1,c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(DateTime.Now, "Good night guys", "See you tomorrow", 10);
            p2.AddComment(c3,c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
