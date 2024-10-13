using System;  
using System.Collections.Generic;  

namespace YoutubeVideos  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Video video1 = new Video("Bahay ni CONGTV", "CongTV", 300);  
            video1.AddComment(new Comment("Alice", "Lupett!"));  
            video1.AddComment(new Comment("Bob", "Angass!"));  
            video1.AddComment(new Comment("Charlie", "Ganda naman ng bahay!"));  

            Video video2 = new Video("Pano magluto ng Sinigang na tubig", "Ninong Ry", 600);  
            video2.AddComment(new Comment("Dave", "Sarap ahaha!"));  
            video2.AddComment(new Comment("Eva", "Galing mo talaga!")); 
            video2.AddComment(new Comment("Harry", "Ma-try nga yang recipe haha."));  

            Video video3 = new Video("Sir Geybin: Gold Trophy Sinira", "Sir Geybin", 1200);  
            video3.AddComment(new Comment("Sara", "kawawa naman si geybin haha!"));  
            video3.AddComment(new Comment("Duterte", "Okay lang yan ganti ka lang ulit."));
            video3.AddComment(new Comment("Bong Bong", "Love lots sa geybinatics!"));

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