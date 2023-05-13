using System;

class Entry {
    /*
        Who was the most interesting person I interacted with today?
        What was the best part of my day?
        How did I see the hand of the Lord in my life today?
        What was the strongest emotion I felt today?
        If I had one thing I could do over today, what would it be?
    */
    

    public static string GenerateEntry(){

        string[] _prompts = new string[] {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random rnd = new Random();
        DateTime now = DateTime.Now;
        string strDate = now.ToString("yyyy-MM-dd");
        string selectedPrompt = _prompts[rnd.Next(0, _prompts.Length)];
        Console.WriteLine(selectedPrompt);
        string response = Console.ReadLine();
        string formatToSave = $"Date: {strDate} - Prompt: {selectedPrompt}\n{response}";
        return formatToSave;
    }
}