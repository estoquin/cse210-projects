class LectureEvent:Event
{

    private string _speaker;
    private int _capacity;
    public LectureEvent(string title, string description, string type, Address address, string speaker, int capacity):base(title, description, type, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public void GenerateFullMessage()
    {
        Console.WriteLine("\n");
        Console.WriteLine($"Event - Lecture");
        GenerateSimpleMessage();
        Console.WriteLine($"Speaker: {this._speaker}");
        Console.WriteLine($"Maximum Capacity: {this._capacity}");
    }
}