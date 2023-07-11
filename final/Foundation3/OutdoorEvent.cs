class OutdoorEvent:Event
{
    private string _weather;
    public OutdoorEvent(string title, string description, Address address, string weather):base(title, description, address)
    {
        SetType("Outdoor Event");
        this._weather = weather;
    }

    public void GenerateFullMessage()
    {
        Console.WriteLine("\n");
        Console.WriteLine(GetEvetntType());
        SimpleDetails();
        Console.WriteLine($"Estimated weather for the day: {this._weather}");
    }
}