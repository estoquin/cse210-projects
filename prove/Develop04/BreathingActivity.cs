public class BreathingActivity:Activity {
    public BreathingActivity(string name, string description):base(name, description)
    {

    }

    public override void StartActivity()
    {
        DisplayWelcomeMessage();
        StartBreathing();
        DisplayEndingMessage();
    }

    private void StartBreathing()
    {
        int duration = GetActivityDuration();
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(duration);
        while (DateTime.Now < endtime)
        {
            Console.Write("\n\nBreathe in...");
            DisplayCounter(4);
            Console.Write("\nNow breathe out...");
            DisplayCounter(6);
        }
    }
}