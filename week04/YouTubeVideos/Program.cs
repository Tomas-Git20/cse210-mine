using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learn C# in 30 Minutes", "Code Academy", 1800);
        video1.AddComment(new Comment("Alice", "Very easy to understand!"));
        video1.AddComment(new Comment("Bob", "This helped me with my homework."));
        video1.AddComment(new Comment("Charlie", "Great explanation."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Travel Destinations", "Travel World", 720);
        video2.AddComment(new Comment("Diana", "I want to visit Japan!"));
        video2.AddComment(new Comment("Ethan", "Amazing video."));
        video2.AddComment(new Comment("Fiona", "Thanks for sharing."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Best Chocolate Cake Recipe", "Cooking with Emma", 900);
        video3.AddComment(new Comment("George", "Delicious recipe."));
        video3.AddComment(new Comment("Hannah", "My family loved it."));
        video3.AddComment(new Comment("Ian", "I'll try this weekend."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Morning Workout Routine", "Fitness Pro", 1200);
        video4.AddComment(new Comment("Jack", "Excellent workout!"));
        video4.AddComment(new Comment("Karen", "I feel energized."));
        video4.AddComment(new Comment("Leo", "Perfect for beginners."));
        videos.Add(video4);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
