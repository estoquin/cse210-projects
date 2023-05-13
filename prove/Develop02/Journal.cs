using System;
using System.IO; 

class Journal {
    List<Entry> _entryList = new List<Entry>();
    
    /*
        @description
    */
    public void AddEntry(){
        Entry newEntry = new Entry();
        newEntry.GenerateEntry();
        _entryList.Add(newEntry);
        Console.WriteLine("Entry added!");
        Console.WriteLine("----------------------------------------------------------------");
    }

    /*
        @description
    */
    public void DisplayEntrys(){
        Console.WriteLine("----------------------------------------------------------------");
        if (_entryList.Count == 0){
            Console.WriteLine("No entries on the journal, add one or read from file");
        } else {
            Console.WriteLine("Journal Entries: \n");
            foreach (Entry entry in _entryList) {
                Console.WriteLine($"\nDate: {entry._entryDate.ToString("yyyy-MM-dd")} - Prompt: {entry._entryPrompt}\n{entry._entryText}");
            }
            Console.WriteLine($"\nTotal Entries: {_entryList.Count}");
        }
    }

    /*
        @description
    */
    public void ReadJournal(){
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        this._entryList.Clear();
        foreach (string line in lines){
            Entry loadedEntry = new Entry();
            loadedEntry._entryDate = Convert.ToDateTime(line.Split("\t")[0]);
            loadedEntry._entryPrompt = line.Split("\t")[1];
            loadedEntry._entryText = line.Split("\t")[2];
            this._entryList.Add(loadedEntry);
        }
        Console.WriteLine("File readed...");
        Console.WriteLine("----------------------------------------------------------------");
    }
    
    /*
        @description
    */
    public void SaveJournal(){
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            foreach (Entry entry in _entryList) {
                outputFile.WriteLine($"{entry._entryDate}\t{entry._entryPrompt}\t{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal Saved to {fileName}");
        Console.WriteLine("----------------------------------------------------------------");
    }
}