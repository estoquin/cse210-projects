class CyclingActivity:Activity
{
    private double _speed;
    public CyclingActivity(DateTime date, int lengthMinutes, double speed):base(date, lengthMinutes)
    {
        this._speed = speed;
    }

    public override double CalculateDistance()
    {
        return GetLenthInMinutes() * (CalculateSpeed() / 60);
    }

    public override double CalculateSpeed()
    {
        return this._speed;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }

    public override void GetSummary()
    {
        double distance = CalculateDistance();
        double pace = CalculatePace();
        pace = Math.Round(pace, 2);
        double speed = CalculateSpeed();
        speed = Math.Round(speed, 2);
        string strDate = GetDateString();
        Console.WriteLine($"{strDate}, Cycling ({GetLenthInMinutes()} mins) - Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per km");
    }
}