using System;

class Entry {
    /*
        Who was the most interesting person I interacted with today?
        What was the best part of my day?
        How did I see the hand of the Lord in my life today?
        What was the strongest emotion I felt today?
        If I had one thing I could do over today, what would it be?
    */

    public DateTime _entryDate = new DateTime();
    public string _entryText;
    public string _entryPrompt;
    

    public void GenerateEntry(){

        // Date
        this._entryDate = DateTime.Now;

        // Prompt
        string[] _prompts = new string[] {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random rnd = new Random();
        string selectedPrompt = _prompts[rnd.Next(0, _prompts.Length)];
        this._entryPrompt = selectedPrompt;

        // Response
        Console.WriteLine(selectedPrompt);
        string response = Console.ReadLine();
        this._entryText = response;
    }
}