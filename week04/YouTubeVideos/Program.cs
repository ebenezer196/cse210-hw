using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Basics", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Very helpful!"));
        video1.AddComment(new Comment("Bob", "Great explanation."));
        video1.AddComment(new Comment("Charlie", "Thanks for this video."));
        videos.Add(video1);

        Video video2 = new Video("OOP Concepts Explained", "Tech World", 850);
        video2.AddComment(new Comment("David", "Nice examples."));
        video2.AddComment(new Comment("Emma", "Clear and simple."));
        video2.AddComment(new Comment("Frank", "Loved the abstraction part."));
        videos.Add(video2);

        Video video3 = new Video("Programming with Classes", "BYU-Idaho", 720);
        video3.AddComment(new Comment("Grace", "This helped my assignment."));
        video3.AddComment(new Comment("Henry", "Perfect timing."));
        video3.AddComment(new Comment("Irene", "Well structured."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.AuthorName}: {comment.Text}");
            }
        }
    }
}
