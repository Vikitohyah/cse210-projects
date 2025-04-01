using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("English Tutorial", "Olalekan David", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Dupe", "Can you make one on Adjectives"));
        videos.Add(video1);

        Video video2 = new Video("Linux Basics", "Afi Olabisi", 900);
        video2.AddComment(new Comment("Aremu", "I love this!"));
        video2.AddComment(new Comment("Evaline", "Please make more!"));
        video2.AddComment(new Comment("Francois", "Subscribed!"));
        videos.Add(video2);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}