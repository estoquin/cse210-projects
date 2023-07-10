class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private Address _address;

    private string _type;
    
    public Event(string title, string description, string type, Address address)
    {
        this._type = type;
        this._description = description;
        this._title = title;
        this._address = address;
    }

    public void SetDate(int year, int month, int day, int hour, int minute)
    {
        DateTime tmpDate = new DateTime(year, month, day, hour, minute, 0);
        this._date = tmpDate;
    }

    public void GenerateShortMessge()
    {
        Console.WriteLine("\n");
        Console.WriteLine($"Title: {this._title}");
        string date = GetDateTimeString().Split(" ")[0];
        Console.WriteLine($"Date: {date}");
    }
    public void GenerateSimpleMessage()
    {
        Console.WriteLine($"Event Title: {this._title}");
        Console.WriteLine($"Description: {this._description}");
        this._address.DisplayAddres();
        Console.WriteLine($"Date: {GetDateTimeString()}");
    }

    public string GetDateTimeString()
    {
        return this._date.ToString("MM/dd/yyy H:mm");
    }
}