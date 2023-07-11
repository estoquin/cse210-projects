class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private Address _address;

    private string _type;
    
    public Event(string title, string description, Address address)
    {
        this._description = description;
        this._title = title;
        this._address = address;
    }

    public string GetEvetntType()
    {
        return this._type;
    }
    public void SetType(string type)
    {
        this._type = type;
    }

    public void SetDate(int year, int month, int day, int hour, int minute)
    {
        DateTime tmpDate = new DateTime(year, month, day, hour, minute, 0);
        this._date = tmpDate;
    }

    public void GenerateShortMessge()
    {
        Console.WriteLine("\n");
        Console.WriteLine(GetEvetntType());
        Console.WriteLine($"Title: {this._title}");
        string date = GetDateTimeString().Split(" ")[0];
        Console.WriteLine($"Date: {date}");
    }
    public void SimpleDetails()
    {
        Console.WriteLine($"Event Title: {this._title}");
        Console.WriteLine($"Description: {this._description}");
        string[] dateTime = GetDateTimeString().Split(" ");
        Console.WriteLine($"Date: {dateTime[0]}");
        Console.WriteLine($"Time: {dateTime[1]}");
        this._address.DisplayAddres();
    }

    public string GetDateTimeString()
    {
        return this._date.ToString("MM/dd/yyy H:mm");
    }
}