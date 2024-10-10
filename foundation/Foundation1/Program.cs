using System;  
using System.Collections.Generic;  

namespace YoutubeVideos  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Video video1 = new Video("Learning C#", "John Doe", 300);  
            video1.AddComment(new Comment("Alice", "Great video!"));  
            video1.AddComment(new Comment("Bob", "Very informative. Thank you!"));  
            video1.AddComment(new Comment("Charlie", "I learned so much!"));  

            Video video2 = new Video("Cooking Pasta", "Jane Smith", 600);  
            video2.AddComment(new Comment("Dave", "Delicious recipe!"));  
            video2.AddComment(new Comment("Eva", "I tried this and it was awesome!"));  

            Video video3 = new Video("Travel Vlog: Italy", "Mark Lee", 1200);  
            video3.AddComment(new Comment("Sara", "Absolutely beautiful places!"));  

            // List of videos  
            List<Video> videos = new List<Video> { video1, video2, video3 };  

            // Display information about each video  
            foreach (var video in videos)  
            {  
                Console.WriteLine(video.GetVideoInfo());  
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");  
                Console.WriteLine("Comments:");  
                foreach (var comment in video.ListComments())  
                {  
                    Console.WriteLine($"  - {comment}");  
                }  
                Console.WriteLine();  // for spacing between videos  
            }  
        }  
    }  
}