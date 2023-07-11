using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date1 = new DateTime(2023, 03, 13);
        DateTime date2 = new DateTime(2022, 02, 11);
        DateTime date3 = new DateTime(2023, 05, 03);

        RunningActivity ra = new RunningActivity(date1, 24, 9.4);
        CyclingActivity ca = new CyclingActivity(date2, 45, 45.3);
        SwimmingActivity sa = new SwimmingActivity(date3, 13, 24);

        List<Activity> activities = new List<Activity>();
        activities.Add(ra);
        activities.Add(ca);
        activities.Add(sa);

        Console.WriteLine("\n");
        foreach(Activity act in activities)
        {
            act.GetSummary();
        }
    }
}