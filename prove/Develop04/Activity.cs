public class Activity {

    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;

    public Activity (string activityName, string activityDescription)
    {
        this._activityDescription = activityDescription;
        this._activityName = activityName;
    }

    public void DisplayWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity!");
        Console.WriteLine($"\n{_activityDescription}\n");
        Console.Write("How long, in seconds, would you like for your session: ");
        this._activityDuration = int.Parse(Console.ReadLine());
        DisplayGetReady();
    }

    public void DisplayGetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!");
        DisplaySpinner(3);
        Console.WriteLine($"You have completed {_activityDuration} seconds of the {_activityName} activity");
        DisplaySpinner(3);
    }

    public void DisplayCounter(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endtime)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds = seconds - 1;
        }
    }

    public void DisplaySpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(seconds);
        List<string> spinnerList = new List<string>();
        spinnerList.Add("|");
        spinnerList.Add("/");
        spinnerList.Add("-");
        spinnerList.Add("\\");
        int index = 0;
        while (DateTime.Now < endtime)
        {
            string s = spinnerList[index];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            index++;
            if(index == spinnerList.Count)
            {
                index = 0;
            }
        }
    }

    public int GetActivityDuration()
    {
        return this._activityDuration;
    }

    public virtual void StartActivity()
    {
        // Override
    }

    public virtual void DisplayInitialPrompt()
    {
        // Override
    }
}
