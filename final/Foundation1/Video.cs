public class Video
{
    public string _title;
    public string _author;
    public int _duration; // in seconds
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = comments;
    }

    public int GetCommentsCount()
    {
        return _comments.Count();
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title} | Created by: {_author} | Duration (in seconds): {_duration} | Number of Comments: {GetCommentsCount()}");
    }

    public void DisplayAllComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommentString()}");
        }
    }
}