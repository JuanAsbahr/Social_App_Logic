using System;
using SocialAppLogic.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Comment c1 = new Comment("Have a nice trip!");
        Comment c2 = new Comment("Wow that's awesoma!");
        Post p1 = new Post(
            DateTime.Parse("07/06/2023  18:26:38"),
            "Treveling to New Zealand",
            "I'm goig to visit this wonderful country!",
            12);

        p1.AddComment (c1);
        p1.AddComment (c2);

        Comment c3 = new Comment("Good night!");
        Comment c4 = new Comment("May the Force be with you");
        Post p2 = new Post(
            DateTime.Parse("05/06/2023 20:45:53"),
            "Good night guys",
            "See you tomorrow",
            5);

        p2.AddComment (c3);
        p2.AddComment (c4);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}