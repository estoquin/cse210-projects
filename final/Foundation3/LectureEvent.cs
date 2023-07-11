class LectureEvent:Event
{

    private string _speaker;
    private int _capacity;
    public LectureEvent(string title, string description, Address address, string speaker, int capacity):base(title, description, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
        SetType("Lecture Event");
    }

    public void GenerateFullMessage()
    {
        Console.WriteLine("\n");
        Console.WriteLine(GetEvetntType());
        SimpleDetails();
        Console.WriteLine($"Speaker: {this._speaker}");
        Console.WriteLine($"Maximum Capacity: {this._capacity}");
    }
}