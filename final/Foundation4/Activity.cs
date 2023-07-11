public abstract class Activity
{
    private DateTime _date;

    private int _lengthMinutes;
    public Activity(DateTime date, int lengthMinutes)
    {
        this._date = date;
        this._lengthMinutes = lengthMinutes;
    }

    public int GetLenthInMinutes()
    {
        return this._lengthMinutes;
    }

    public string GetDateString()
    {
        return this._date.ToString("dd MMMM yyyy");
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public abstract void GetSummary();
}