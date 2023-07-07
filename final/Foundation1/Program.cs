using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video v1 = new Video("Cute cats", "catLover2920", 505);
        v1.AddComment("loveCat123", "Beautifoul cats!!");
        v1.AddComment("cat23", "I miss my cat...");
        v1.AddComment("love321", "I want more cats!");
        videos.Add(v1);

        Video v2 = new Video("Best Movies ever", "myCinema.com", 123);
        v2.AddComment("andrea123", "You missed Gladiator!");
        v2.AddComment("martincho", "lovely!");
        v2.AddComment("jojoMovies", "Want more of this!");
        videos.Add(v2);

        Video v3 = new Video("10 must read books", "LovingBooks", 343);
        v3.AddComment("juanCarlos", "I recommend Ben Hur");
        v3.AddComment("moreBooks", "Good books");
        v3.AddComment("jennifer", "Can you create a list in love books?");
        videos.Add(v3);

        Video v4 = new Video("How to start gym", "FitForLove", 475);
        v4.AddComment("nico123", "Thanks for the advice!!");
        v4.AddComment("carlosZapata", "It helps me with motivation");
        v4.AddComment("MoreFit", "This are great exercises!");
        videos.Add(v4);

        // Abstraction: In this single line of code, all the video information is shown
        // and we don't worrie about how it works!.
        foreach(Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}