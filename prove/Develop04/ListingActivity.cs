public class ListingActivity:Activity {

    private List<string> _responses;
    private List<string> _prompts;

    public ListingActivity(string name, string description):base(name, description)
    {
        List<string> prompts = new List<string>();
        prompts.Add("When was the last time you felt the spirit?");
        prompts.Add("Why is the Temple important for you?");
        prompts.Add("How can you improve your faith in the lord?");
        this._prompts = prompts;
    }

    public override void StartActivity()
    {
        DisplayWelcomeMessage();
        DisplayInitialPrompt();
        StartListing();
        DisplayEndingMessage();
    }

    public override void DisplayInitialPrompt()
    {
        int randomNumber = new Random().Next(0, _prompts.Count);
        Console.WriteLine("List as many responses to the following prompt: ");
        Console.WriteLine($"-- {_prompts[randomNumber]} --");
        Console.Write("You may begin in: ");
        DisplayCounter(5);
    }

    private void StartListing()
    {
        int duration = GetActivityDuration();
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(duration);
        List<string> tmpResponses = new List<string>();
        Console.Write("\n");
        while (DateTime.Now < endtime)
        {
            Console.Write(">");
            tmpResponses.Add(Console.ReadLine());
        }
        this._responses=tmpResponses;
        Console.WriteLine($"You listed {this._responses.Count} items!");
    }
}