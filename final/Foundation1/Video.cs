class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    
    public Video(string title, string author, int length)
    {
        this._author = author;
        this._title = title;
        this._length = length;
        List<Comment> comments = new List<Comment>();
        this._comments = comments;
    }

    public string GetAuthor()
    {
        return this._author;
    }

    public string GetTitle()
    {
        return this._title;
    }

    public int GetLenth()
    {
        return this._length;
    }

    public void AddComment(string name, string comment)
    {
        List<Comment> comments = new List<Comment>();
        comments = this._comments;
        Comment c = new Comment(name, comment);
        comments.Add(c);
        this._comments = comments;
    }

    public int GetCommentsQuantity()
    {
        return this._comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine("\n---------------------------------------------");
        Console.WriteLine($"Title: {this._title}");
        Console.WriteLine($"Author: {this._author}");
        Console.WriteLine($"Length (seconds): {this._length}");
        
        if(this._comments.Count > 0)
        {
            List<Comment> comments = new List<Comment>();
            comments = this._comments;
            Console.WriteLine("Video comments: ");
            foreach(Comment c in comments)
            {
                string comment = c.GetComment();
                string name = c.GetName();
                Console.WriteLine($"\t - \"{comment}\" (by {name})");
            }
        }
    }
}