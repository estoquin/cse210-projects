using System;
using System.IO; 

class Journal {
    List<string> _entryList = new List<string>();
    
    /*
        @description
    */
    public void AddEntry(){
        string newEntry = Entry.GenerateEntry();
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
            foreach (string entry in _entryList) {
                Console.WriteLine($"\n{entry}");
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
        string entryToAdd = "";
        foreach (string line in lines) {
            if (entryToAdd == ""){
                entryToAdd = $"{line}";
            } else {
                entryToAdd = $"{entryToAdd}\n{line}";
            }
            int elementNumber = Array.IndexOf(lines, line);
            if ((elementNumber != 0) && ((elementNumber % 2) != 0)){
                _entryList.Add(entryToAdd);
                entryToAdd = "";
            }
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
            foreach (string entry in _entryList) {
                outputFile.WriteLine(entry);
            }
        }
        Console.WriteLine($"Journal Saved to {fileName}");
        Console.WriteLine("----------------------------------------------------------------");
    }
}