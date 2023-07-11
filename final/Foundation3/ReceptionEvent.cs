class ReceptionEvent:Event
{
    private string _email;
    public ReceptionEvent(string title, string description, Address address, string email):base(title, description, address)
    {
        SetType("Reception Event");
        this._email = email;
    }

    public void GenerateFullMessage()
    {
        Console.WriteLine("\n");
        Console.WriteLine(GetEvetntType());
        SimpleDetails();
        Console.WriteLine($"Please confirm your attendance to: {this._email}");
    }
}