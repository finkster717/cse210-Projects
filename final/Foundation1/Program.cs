using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Creating a list to store videos
        List<Video> videos = new List<Video>();

        // Creating a list for the each video's comments
        List<Comment> video1Comments = new List<Comment>();
        List<Comment> video2Comments = new List<Comment>();
        List<Comment> video3Comments = new List<Comment>();

        // Adding comments to the first video's list
        video1Comments.Add(new Comment("Hagrid", "Maybe if you were nicer to the poor spider you wouldn't need to fight it."));
        video1Comments.Add(new Comment("Galadriel", "Use that light thing I gave you, like, two movies ago!"));
        video1Comments.Add(new Comment("Peter Jackson", "Thank you, I'll use this information to make this scene in the movie as gross as possible."));
        // Adding comments to the second video's list
        video2Comments.Add(new Comment("Nephi", "So great were the blessings of the Lord upon us, that we did live upon raw meat in the wilderness. (paraphrased from 1 Nephi 17:2)"));
        video2Comments.Add(new Comment("Aragorn", "But you already had breakfast..."));
        video2Comments.Add(new Comment("Lehi", "As I partook of the fruit thereof it filled my soul with exceedingly great joy; wherefore, I began to be desirous that my family should partake of it also; for I knew that it was desirable above all other fruit. (1 Nephi 8:12)"));
        // Adding comments to the third video's list
        video3Comments.Add(new Comment("Voldemort", "Whatever man, I made like seven things just like that and the main characters still destroyed them and defeated me."));
        video3Comments.Add(new Comment("John Notanevilmastermind", "Very informative, thank you for this knowledge."));
        video3Comments.Add(new Comment("King Laban", "Behold, thou art a robber, and I will slay thee and take thy ring of power. (paraphrased from 1 Nephi 3:13)"));

        // Adding videos to the list of videos
        videos.Add(new Video("Fighting A Giant Spider", "Samwise Gamgee", 600, video1Comments));
        videos.Add(new Video("Preparing Second Breakfast", "Peregrin Took", 350, video2Comments));
        videos.Add(new Video("How To Forge A Ring Of Power", "Sauron", 900, video3Comments));

        // Display the content
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
            video.DisplayAllComments();
            Console.WriteLine();
        }

        Console.Write("Press ENTER to end the program... ");
        Console.ReadLine();
    }
}