public class ReflectingActivity:Activity {

    private List<string> _randomPrompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description):base(name, description)
    {
        List<string> randomPrompts = new List<string>();
        randomPrompts.Add("Think of a time when you did something really dificult.");
        randomPrompts.Add("Think of a situation that you'll never want to live.");
        randomPrompts.Add("Think of a challenge that Heavenly Father gave to you.");
        this._randomPrompts = randomPrompts;
        List<string> questions = new List<string>();
        questions.Add("What is the important thing you can get from this");
        questions.Add("How can this experience help you in the future");
        questions.Add("How can this experience help others around you");
        questions.Add("How can this help you become a better person");
        questions.Add("How can this help you become a better disciple of Christ");
        questions.Add("What you must do in order to overcome this.");
        this._questions = questions;
    }

    public override void StartActivity()
    {
        DisplayWelcomeMessage();
        DisplayInitialPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public override void DisplayInitialPrompt()
    {
        Console.WriteLine("Consider the following propmt: ");
        int randomNumber = new Random().Next(0, _randomPrompts.Count);
        Console.WriteLine($"\n-- {_randomPrompts[randomNumber]} --\n");
        Console.WriteLine("When you have something in mind, press enter to continue: ");
        Console.ReadLine();
    }

    private void DisplayQuestions()
    {
        Console.WriteLine("Now, ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        DisplayCounter(3);
        int duration = GetActivityDuration();
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(duration);
        int index = 0;
        while (DateTime.Now < endtime)
        {
            Console.Write($"\n> {_questions[index]} ");
            DisplaySpinner(7);
            index++;
        }
    }

}