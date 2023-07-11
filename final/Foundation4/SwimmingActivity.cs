class SwimmingActivity:Activity
{
    private int _laps;
    public SwimmingActivity(DateTime date, int lengthMinutes, int laps):base(date, lengthMinutes)
    {
        this._laps = laps;
    }

    public override double CalculateDistance()
    {
        return (this._laps * 50) / 1000;
    }

    public override double CalculateSpeed()
    {
        return (CalculateDistance() / GetLenthInMinutes()) * 60;
    }

    public override double CalculatePace()
    {
        return GetLenthInMinutes() / CalculateDistance();
    }

    public override void GetSummary()
    {
        double distance = CalculateDistance();
        double pace = CalculatePace();
        pace = Math.Round(pace, 2);
        double speed = CalculateSpeed();
        speed = Math.Round(speed, 2);
        string strDate = GetDateString();
        Console.WriteLine($"{strDate}, Swimming ({GetLenthInMinutes()} mins) - Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per km");
    }
}