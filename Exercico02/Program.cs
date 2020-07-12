using System;
using Exercico02.Entities;
using Exercico02.Entitis;

namespace Exercico02
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("have a nice strip");
            Comment c2 = new Comment("Wow that´s awesome");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeeland", "I´m going to visit this wonderfoul country", 12);
            p1.AddComments(c1);
            p1.AddComments(c2);

            Comment c3 = new Comment("Good nigth");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good nitgh Guys", "See you tomorrow", 5);
            p2.AddComments(c3);
            p2.AddComments(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
