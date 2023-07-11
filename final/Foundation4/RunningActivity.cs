class RunningActivity:Activity
{
    private double _distance;
    public RunningActivity(DateTime date, int lengthMinutes, double distance):base(date, lengthMinutes)
    {
        this._distance = distance;
    }

    public override double CalculateDistance()
    {
        return this._distance;
    }

    public override double CalculateSpeed()
    {
        return (this._distance / GetLenthInMinutes()) * 60;
    }

    public override double CalculatePace()
    {
        return GetLenthInMinutes() / this._distance;
    }

    public override void GetSummary()
    {
        double distance = CalculateDistance();
        double pace = CalculatePace();
        pace = Math.Round(pace, 2);
        double speed = CalculateSpeed();
        speed = Math.Round(speed, 2);
        string strDate = GetDateString();
        Console.WriteLine($"{strDate},  Running ({GetLenthInMinutes()} mins) - Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per km");
    }
}